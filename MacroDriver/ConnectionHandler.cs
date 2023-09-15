using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace MacroDriver
{
    class ConnectionHandler
    {
        MacroDriver driver;
        SerialPort myPort;

        public ConnectionHandler(MacroDriver driver)
        {
            this.driver = driver;
        }

        public SerialPort Setup(String portName, int baudRate)
        {
            if (baudRate > 0)
            {
                TBConsole.WriteLine("Connecting to port ");
                myPort = new SerialPort();
                myPort.BaudRate = baudRate;
                myPort.PortName = portName;
                try
                {
                    myPort.Open();
                }
                catch (ArgumentException)
                {
                    TBConsole.WriteLine("Incorrect port name");
                    return null;
                }
                catch (UnauthorizedAccessException)
                {
                    TBConsole.WriteLine("Access denied to port");
                    return null;
                }
                catch (InvalidOperationException)
                {
                    TBConsole.WriteLine("Port already in use");
                    return null;
                }
                TBConsole.WriteLine($"Connected to port {portName}");
                try
                {
                    myPort.Write("Layer " + (driver.GetActiveLayer() + 1));
                }
                catch (TimeoutException)
                {
                    TBConsole.WriteLine("Couldn't write device: timeout");
                    return null;
                }
                catch
                {
                    TBConsole.WriteLine("Couldn't write device");
                    return null;
                }
                driver.IsConnected = true;
                driver.MyPort = myPort;
                Loop looper = new Loop(driver);
                ThreadStart starter1 = new ThreadStart(looper.Looping);
                Thread backgroundThread1 = new Thread(starter1);
                backgroundThread1.Start();
                return myPort;
            }
            else
            {
                TBConsole.WriteLine("Incorrect Baud Rate");
                return null;
            }
        }

        public void Close()
        {
            if (myPort != null)
            {
                myPort.Close();
            }
        }

    }
}
