using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace MacroDriver
{
    class FileHandler
    {
        MacroDriver driver;
        string directory;

        public FileHandler(MacroDriver driver)
        {
            this.driver = driver;
            InitializeDirectory();
        }

        public FileHandler()
        {
            driver = null;
            InitializeDirectory();
        }

        private void InitializeDirectory()
        {
            this.directory = Application.ExecutablePath;
            this.directory = Directory.GetParent(directory).FullName;
            this.directory = Directory.GetParent(directory).FullName;
            this.directory = this.directory + "\\layout";
        }

        public void LoadConfig()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("config.ini");
                String read;
                while ((read = reader.ReadLine()) != null)
                {
                    String[] readSplit = read.Split(' ');
                    if (readSplit[0] == "filename")
                    {
                        Settings.DefaultFile = readSplit[2];
                        continue;
                    }
                    if (readSplit[0] == "remainopen")
                    {
                        if (readSplit[2] == "True")
                        {
                            Settings.RemainOpen = true;
                        }
                        if (readSplit[2] == "False")
                        {
                            Settings.RemainOpen = false;
                        }
                            continue;
                    }
                    if (readSplit[0] == "baudrate")
                    {
                        Settings.DefaultBaudRate = int.Parse(readSplit[2]);
                        continue;
                    }
                    if (readSplit[0] == "portname")
                    {
                        Settings.DefaultPort = readSplit[2];
                        continue;
                    }
                    if (readSplit[0] == "connect")
                    {
                        if (readSplit[2] == "True")
                        {
                            Settings.AutoConnect = true;
                        }
                        if (readSplit[2] == "False")
                        {
                            Settings.AutoConnect = false;
                        }
                        continue;
                    }
                    /*if (readSplit[0] == "lights")
                    {
                        if (readSplit[2] == "True")
                        {
                            Settings.DefaultLED = true;
                            driver.SetLED(1);
                        }
                        if (readSplit[2] == "False")
                        {
                            Settings.DefaultLED = false;
                            driver.SetLED(0);
                        }
                        continue;
                    }*/
                    if (readSplit[0] == "sequencemode")
                    {
                        if (readSplit[2] == "True")
                        {
                            Settings.SequenceMode = true;
                        }
                        else
                        {
                            Settings.SequenceMode = false;
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine("Config.ini not found");
                return;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine("Config.ini could not be read");
                return;
            }
            finally
            {
                if(reader != null)
                    reader.Close();
            }
            TBConsole.WriteLine("Settings loaded");
        }



        public void WriteConfig()
        {
            StreamWriter writer;
            try
            {
                writer = new StreamWriter("config.ini");
                writer.WriteLine("[File]");
                writer.WriteLine(";; name of the file to load on default");
                writer.WriteLine("filename = " + Settings.DefaultFile);
                writer.WriteLine();
                writer.WriteLine("[Driver]");
                writer.WriteLine(";; reamain open on tray");
                writer.WriteLine("remainopen = " + Settings.RemainOpen);
                writer.WriteLine();
                writer.WriteLine(";; should send sequence or combination");
                writer.WriteLine("sequencemode = " + Settings.SequenceMode);
                writer.WriteLine();
                writer.WriteLine("[Arduino]");
                writer.WriteLine(";; baud rate set in Arduino code");
                writer.WriteLine("baudrate = " + Settings.DefaultBaudRate);
                writer.WriteLine(";; default port");
                writer.WriteLine("portname = " + Settings.DefaultPort);
                writer.WriteLine(";; wether the computer should connect to the Arduino automatically");
                writer.WriteLine("connect = " + Settings.AutoConnect);
                writer.WriteLine();
                writer.WriteLine("[Keyboard]");
                writer.WriteLine(";; starting state of background LEDs");
                writer.WriteLine("lights = " + Settings.DefaultLED);
                writer.Close();
            }
            catch
            {
                TBConsole.WriteLine("Could not save settings");
                return;
            }
            TBConsole.WriteLine("Settings saved");
        }

        
        public void ReadFile(String fileName)
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader($"{ directory }\\{ fileName}");
                int i = 0;
                int j = 0;
                String read;
                List<List<String>[]> layers = driver.GetLayers();
                while ((read = reader.ReadLine()) != null && !reader.EndOfStream && i < 22)
                {
                    if (read == "new_layer" || i == 21)
                    {
                        layers.Add(new List<String>[20]);
                        j++;
                        i = 0;
                        continue;
                    }
                    if (driver.GetLayers()[j][i] == null)
                    {
                        layers[j][i] = new List<String>();
                    }
                    if (read == "pass_line")
                    {
                        layers[j][i].Add("");
                        i++;
                    }
                    else
                    {
                        String[] split = read.Split();
                        foreach (String substring in split)
                        {
                            layers[j][i].Add(substring);
                        }
                        i++;
                    }
                }
                reader.Close();
                WriteFile(fileName);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine("File not found");
                return;
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine("Could not load file");
                return;
            }
            catch (IOException EX)
            {
                Console.WriteLine(EX.Message);
                TBConsole.WriteLine("File could not be read");
                return;
            }
            TBConsole.WriteLine($"File {fileName} read");
        }
        

        public void WriteFile(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream($"{fileName}.layout", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, driver.GetLayers());
            stream.Close();
        }

        /*public void ReadFile(string fileName)
        {
            Stream stream = null;
            try
            {
                stream = new FileStream($"{directory}\\{fileName}.layout", FileMode.Open, FileAccess.Read, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                driver.SetLayers((List<List<String>[]>)formatter.Deserialize(stream));
                TBConsole.WriteLine($"File {fileName}.layout read");

            }
            catch(SerializationException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine("An error occured while loading the layout");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine($"File not found");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine($"File directory not found");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine($"File could not be loaded");
            }
            finally
            {
                if(stream != null)
                    stream.Close();
            }
        }*/
        
    }
}
