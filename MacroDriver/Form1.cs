using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using System.Windows.Input;

namespace MacroDriver
{
    // Main form class
    public partial class MacroDriver : Form
    {
        // Foreground params
        string version = "v0.3";
        String[] ports;
        int baudRate = -1;
        String portName = "";

        // Background params
        List<List<String>[]> layers = new List<List<String>[]>();
        int activeLayer = 0;
        bool isConnected;
        SerialPort myPort;
        int areLEDsActive = 0;
        private bool dragging = false;
        private Point startPoint;
        InputSimulator sim;
        Dictionary<String, VirtualKeyCode> keys;
        ConnectionHandler connectionHandler;

        //Properties
        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }
        public SerialPort MyPort
        {
            get { return myPort; }
            set { myPort = value; }
        }

        #region ctor

        public MacroDriver()
        {
            InitializeComponent();
            TBConsole.Form = this;
            TBConsole.WriteLine($"Running MacroDriver {version}");
            Initialize();
            LoadConfig();
        }

        #endregion

        #region AtStart

        private void Initialize()
        {
            TBConsole.WriteLine("Initializing variables");
            cbPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            isConnected = false;
            sim = new InputSimulator();
            connectionHandler = new ConnectionHandler(this);
            keys = new Dictionary<String, VirtualKeyCode>();
            InitializeKeys();
            layers.Add(new List<String>[20]);
            FillComboBox();
            this.notifyIcon.ContextMenuStrip = this.iconMenuStrip;
            this.bDisconnect.Hide();
            TBConsole.WriteLine("Variables initialized");
        }

        private void InitializeKeys()
        {
            keys.Add("A", VirtualKeyCode.VK_A);
            keys.Add("B", VirtualKeyCode.VK_B);
            keys.Add("C", VirtualKeyCode.VK_C);
            keys.Add("D", VirtualKeyCode.VK_D);
            keys.Add("E", VirtualKeyCode.VK_E);
            keys.Add("F", VirtualKeyCode.VK_F);
            keys.Add("G", VirtualKeyCode.VK_G);
            keys.Add("H", VirtualKeyCode.VK_H);
            keys.Add("I", VirtualKeyCode.VK_I);
            keys.Add("J", VirtualKeyCode.VK_J);
            keys.Add("K", VirtualKeyCode.VK_K);
            keys.Add("L", VirtualKeyCode.VK_L);
            keys.Add("M", VirtualKeyCode.VK_M);
            keys.Add("N", VirtualKeyCode.VK_N);
            keys.Add("O", VirtualKeyCode.VK_O);
            keys.Add("P", VirtualKeyCode.VK_P);
            keys.Add("Q", VirtualKeyCode.VK_Q);
            keys.Add("R", VirtualKeyCode.VK_R);
            keys.Add("S", VirtualKeyCode.VK_S);
            keys.Add("T", VirtualKeyCode.VK_T);
            keys.Add("U", VirtualKeyCode.VK_U);
            keys.Add("V", VirtualKeyCode.VK_V);
            keys.Add("W", VirtualKeyCode.VK_W);
            keys.Add("X", VirtualKeyCode.VK_X);
            keys.Add("Y", VirtualKeyCode.VK_Y);
            keys.Add("Z", VirtualKeyCode.VK_Z);
            keys.Add("SHIFT", VirtualKeyCode.SHIFT);
            keys.Add("CTRL", VirtualKeyCode.CONTROL);
            keys.Add("ALT", VirtualKeyCode.MENU);
            keys.Add("SPACE", VirtualKeyCode.SPACE);
            keys.Add("ENTER", VirtualKeyCode.RETURN);
            keys.Add("HOME", VirtualKeyCode.HOME);
            keys.Add("DEL", VirtualKeyCode.DELETE);
            keys.Add("BACKSPACE", VirtualKeyCode.BACK);
            keys.Add("PAGEUP", VirtualKeyCode.PRIOR);
            keys.Add("PAGEDOWN", VirtualKeyCode.NEXT);
            keys.Add("UP", VirtualKeyCode.UP);
            keys.Add("DOWN", VirtualKeyCode.DOWN);
            keys.Add("LEFT", VirtualKeyCode.LEFT);
            keys.Add("RIGHT", VirtualKeyCode.RIGHT);
            keys.Add("MULTIPLY", VirtualKeyCode.MULTIPLY);
            keys.Add("DIVIDE", VirtualKeyCode.DIVIDE);
            keys.Add("ADD", VirtualKeyCode.ADD);
            keys.Add("SUBTRACT", VirtualKeyCode.SUBTRACT);
            keys.Add("F1", VirtualKeyCode.F1);
            keys.Add("F2", VirtualKeyCode.F2);
            keys.Add("F3", VirtualKeyCode.F3);
            keys.Add("F4", VirtualKeyCode.F4);
            keys.Add("F5", VirtualKeyCode.F5);
            keys.Add("F6", VirtualKeyCode.F6);
            keys.Add("F7", VirtualKeyCode.F7);
            keys.Add("F8", VirtualKeyCode.F8);
            keys.Add("F9", VirtualKeyCode.F9);
            keys.Add("F10", VirtualKeyCode.F10);
            keys.Add("F11", VirtualKeyCode.F11);
            keys.Add("F12", VirtualKeyCode.F12);
            keys.Add("0", VirtualKeyCode.VK_0);
            keys.Add("1", VirtualKeyCode.VK_1);
            keys.Add("2", VirtualKeyCode.VK_2);
            keys.Add("3", VirtualKeyCode.VK_3);
            keys.Add("4", VirtualKeyCode.VK_4);
            keys.Add("5", VirtualKeyCode.VK_5);
            keys.Add("6", VirtualKeyCode.VK_6);
            keys.Add("7", VirtualKeyCode.VK_7);
            keys.Add("8", VirtualKeyCode.VK_8);
            keys.Add("9", VirtualKeyCode.VK_9);
            keys.Add("NUM0", VirtualKeyCode.NUMPAD0);
            keys.Add("NUM1", VirtualKeyCode.NUMPAD1);
            keys.Add("NUM2", VirtualKeyCode.NUMPAD2);
            keys.Add("NUM3", VirtualKeyCode.NUMPAD3);
            keys.Add("NUM4", VirtualKeyCode.NUMPAD4);
            keys.Add("NUM5", VirtualKeyCode.NUMPAD5);
            keys.Add("NUM6", VirtualKeyCode.NUMPAD6);
            keys.Add("NUM7", VirtualKeyCode.NUMPAD7);
            keys.Add("NUM8", VirtualKeyCode.NUMPAD8);
            keys.Add("NUM9", VirtualKeyCode.NUMPAD9);
            //Experimental Keys - Can only be set from txt files
            keys.Add("SEMICOLON", VirtualKeyCode.OEM_1);
            keys.Add("PERIOD", VirtualKeyCode.OEM_PERIOD);
            keys.Add("OPEN_BRACKET", VirtualKeyCode.OEM_4);
            keys.Add("CLOSE_BRACKET", VirtualKeyCode.OEM_6);
            keys.Add("CAPS", VirtualKeyCode.CAPITAL);
            keys.Add("ESC", VirtualKeyCode.ESCAPE);
            keys.Add("BACKSLASH", VirtualKeyCode.OEM_5);
            keys.Add("TAB", VirtualKeyCode.TAB);

            //keys.Add(Keys.OemSemicolon, "SEMICOLON");
            //keys.Add(Keys.OemPeriod, "PERIOD");
            //keys.Add(Keys.Oemcomma, "COMMA");
            //keys.Add(Keys.OemOpenBrackets, "OPEN_BRACKET");
            //keys.Add(Keys.OemCloseBrackets, "CLOSE_BRACKET");
            //keys.Add(Keys.CapsLock, "CAPS");
            //keys.Add(Keys.Escape, "ESC");
            //keys.Add(Keys.OemBackslash, "BACKSLASH");
            //keys.Add(Keys.Tab, "TAB");
        }


        /// <summary>
        /// Fills combobox with available ports
        /// </summary>
        private void FillComboBox()
        {
            ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                cbPorts.Items.Add(port);
            }
        }

        #endregion


        public void SetLED(int led) { }

        #region FileHandling

        /// <summary>
        /// Loads "config.ini" file for saveable default settings
        /// </summary>
        private void LoadConfig()
        {
            FileHandler handler = new FileHandler(this);
            handler.LoadConfig();
            if (Settings.DefaultBaudRate > 0)
            {
                this.baudRate = Settings.DefaultBaudRate;
                this.tbBaudRate.Text = baudRate.ToString();
            }
            if ((this.portName = Settings.DefaultPort) != "")
            {
                if (cbPorts.Items.Contains(portName))
                {
                    cbPorts.SelectedIndex = cbPorts.Items.IndexOf(portName);
                }
            }
            if (Settings.DefaultFile != "")
            {
                handler.ReadFile(Settings.DefaultFile);
            }
        }

        /// <summary>
        /// Writes config after change in settings
        /// </summary>
        private void WriteConfig()
        {
            FileHandler handler = new FileHandler(this);
            handler.WriteConfig();
        }

        /// <summary>
        /// Reads the file given
        /// </summary>
        /// <param name="fileName"></param>
        private void ReadFile(String fileName)
        {
            FileHandler handler = new FileHandler(this);
            handler.ReadFile(fileName);
        }

        #endregion

        #region Events

        private void MacroDriver_Activated(object sender, EventArgs e)
        {
            bConnect.Focus();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            ReadFile(tbLayout.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDialog dialog = new SettingsDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.SaveSettings();
            }
        }
        private void MacroDriver_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing ||
                e.CloseReason == CloseReason.ApplicationExitCall)
            {
                connectionHandler.Close();
                return;
            }
            if (Settings.RemainOpen)
            {
                e.Cancel = true;
                this.notifyIcon.Visible = true;
                this.Hide();
            }
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = false;
            this.Show();
        }
        private void miOpen_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = false;
            this.Show();
        }
        private void miExit_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = false;
            Application.Exit();
        }
        private void bConnect_Click(object sender, EventArgs e)
        {
            if (isConnected) { return; }

            try
            {
                connectionHandler.Setup(this.portName, this.baudRate);
                this.bConnect.Hide();
                this.bDisconnect.Show();
                this.isConnected = true;
            }
            catch (Exception ex)
            {
                this.bConnect.Show();
                this.bDisconnect.Hide();
                this.isConnected = false;
                TBConsole.WriteLine("Failed to connect to device");
                TBConsole.WriteLine(ex.Message);
            }
        }
        private void bDisconnect_Click(object sender, EventArgs e)
        {
            if (!isConnected) { return; }

            connectionHandler.Close();
            this.isConnected = false;
            this.bDisconnect.Hide();
            this.bConnect.Show();
            TBConsole.WriteLine("Disconnected from port");
        }
        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.portName = cbPorts.SelectedItem.ToString();
        }

        private void tbBaudRate_TextChanged(object sender, EventArgs e)
        {
            this.baudRate = int.Parse(tbBaudRate.Text);
        }

        #endregion

        #region Getters

        public TextBox GetConsole()
        {
            return this.Console;
        }

        public int GetBaudRate()
        {
            return baudRate;
        }

        public String[] GetPorts()
        {
            return ports;
        }

        public SerialPort GetPort()
        {
            return myPort;
        }

        public int GetLED()
        {
            return areLEDsActive;
        }

        public List<List<String>[]> GetLayers()
        {
            return layers;
        }

        public int GetActiveLayer()
        {
            return activeLayer;
        }

        public bool GetIsConnected()
        {
            return isConnected;
        }

        public Dictionary<String, VirtualKeyCode> GetKeys()
        {
            return keys;
        }

        #endregion

        #region Setters

        public void SetLayers(List<List<String>[]> read)
        {
            layers = read;
        }



        #endregion

        
    }
}
