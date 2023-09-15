using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using WindowsInput.Native;
using WindowsInput;

namespace MacroDriver
{
    class Loop
    {
        MacroDriver driver;
        //ConnectionChecker checker;

        public Loop(MacroDriver driver/*, ConnectionChecker checker*/)
        {
            this.driver = driver;
            //this.checker = checker;
        }

        /// <summary>
        /// Looped while connected to a port.
        /// </summary>
        public void Looping()
        {
            System.Console.WriteLine("Looping");
            InputSimulator sim = new InputSimulator();
            SerialPort myPort = driver.GetPort();
            List<List<String>[]> layers = driver.GetLayers();
            int activeLayer = driver.GetActiveLayer();
            while (driver.GetIsConnected())
            {
                try
                {
                    if (myPort.BytesToRead <= 0) { continue; }

                    int keyPressed = int.Parse(myPort.ReadLine());
                    if (driver.GetLayers()[driver.GetActiveLayer()][keyPressed - 1][0] == "LED")
                    {
                        //driver.SwitchLEDs();
                        continue;
                    }
                    if (layers[activeLayer][keyPressed - 1][0] == "layer_up")
                    {
                        if (activeLayer < layers.Count - 1 || (activeLayer == 0 && layers.Count >= 2))
                        {
                            activeLayer++;
                            String send = $"Layer {(activeLayer + 1).ToString()}";
                            myPort.Write(send);
                        }
                        continue;
                    }
                    if (layers[activeLayer][keyPressed - 1][0] == "layer_down")
                    {
                        if (activeLayer > 0)
                        {
                            activeLayer--;
                            String send = "Layer " + (activeLayer + 1).ToString();
                            myPort.Write(send);
                        }
                        continue;
                    }
                    if (Settings.SequenceMode)
                    {
                        foreach (String simulatedKey in layers[activeLayer][keyPressed - 1])
                        {
                            if (!driver.GetKeys().ContainsKey(simulatedKey)) { continue; }
                            sim.Keyboard.KeyPress(driver.GetKeys()[simulatedKey]);
                            sim.Keyboard.Sleep(200);
                        }
                    }
                    else
                    {
                        foreach (String simulatedKey in layers[activeLayer][keyPressed - 1])
                        {
                            if (!driver.GetKeys().ContainsKey(simulatedKey)) { continue; }
                            sim.Keyboard.KeyDown(driver.GetKeys()[simulatedKey]);
                        }
                        foreach (String simulatedKey in layers[activeLayer][keyPressed - 1])
                        {
                            if (!driver.GetKeys().ContainsKey(simulatedKey)) { continue; }
                            sim.Keyboard.KeyUp(driver.GetKeys()[simulatedKey]);
                        }
                    }
                    myPort.DiscardInBuffer();
                }
                catch
                {
                    Console.WriteLine("Error");
                    continue;
                }
            }
        }
    }
}