using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MacroDriver
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            Initalize();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.bOK.DialogResult = DialogResult.OK;
        }

        public void Initalize()
        {
            this.tbDefaultFile.Text = Settings.DefaultFile;
            this.tbDefaultBaudRate.Text = Settings.DefaultBaudRate.ToString();
            this.tbDefaultPort.Text = Settings.DefaultPort;
            this.cbSequenceMode.Items.Add("Sequence");
            this.cbSequenceMode.Items.Add("Combination");
            if(Settings.SequenceMode)
                this.cbSequenceMode.SelectedIndex = this.cbSequenceMode.Items.IndexOf("Sequence");
            else
                this.cbSequenceMode.SelectedIndex = this.cbSequenceMode.Items.IndexOf("Combination");

            this.chConnectAutomatically.Checked = Settings.AutoConnect;
            this.chRemainOpen.Checked = Settings.RemainOpen;
        }

        public void SaveSettings()
        {
            Settings.DefaultFile = this.tbDefaultFile.Text;
            try
            {
                if (tbDefaultBaudRate.Text != "")
                    Settings.DefaultBaudRate = int.Parse(this.tbDefaultBaudRate.Text);
                else
                    Settings.DefaultBaudRate = -1;
            }
            catch(Exception ex)
            {
                Settings.DefaultBaudRate = -1;
                Console.WriteLine(ex.Message);
                TBConsole.WriteLine("Invalid baud rate");
            }
            Settings.DefaultPort = this.tbDefaultPort.Text;
            if (this.cbSequenceMode.SelectedIndex == this.cbSequenceMode.Items.IndexOf("Sequence"))
                Settings.SequenceMode = true;
            else
                Settings.SequenceMode = false;
            Settings.AutoConnect = chConnectAutomatically.Checked;
            Settings.RemainOpen = chRemainOpen.Checked;

            FileHandler handler = new FileHandler();
            handler.WriteConfig();
        }
    }
}
