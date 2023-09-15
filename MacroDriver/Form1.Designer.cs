using System.Drawing;

namespace MacroDriver
{
    partial class MacroDriver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroDriver));
            tbConsole = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lConsole = new System.Windows.Forms.Label();
            pConsole = new System.Windows.Forms.Panel();
            pInput = new System.Windows.Forms.Panel();
            bDisconnect = new System.Windows.Forms.Button();
            bLoad = new System.Windows.Forms.Button();
            lFileName = new System.Windows.Forms.Label();
            lBaudRate = new System.Windows.Forms.Label();
            tbLayout = new System.Windows.Forms.TextBox();
            tbBaudRate = new System.Windows.Forms.TextBox();
            lPorts = new System.Windows.Forms.Label();
            cbPorts = new System.Windows.Forms.ComboBox();
            bConnect = new System.Windows.Forms.Button();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            iconMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            miOpen = new System.Windows.Forms.ToolStripMenuItem();
            miExit = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            pConsole.SuspendLayout();
            pInput.SuspendLayout();
            iconMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tbConsole
            // 
            tbConsole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbConsole.Location = new Point(54, 54);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbConsole.Size = new Size(582, 193);
            tbConsole.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { programToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(702, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(80, 24);
            programToolStripMenuItem.Text = "Program";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(145, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // lConsole
            // 
            lConsole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lConsole.AutoSize = true;
            lConsole.Location = new Point(54, 31);
            lConsole.Name = "lConsole";
            lConsole.Size = new Size(62, 20);
            lConsole.TabIndex = 2;
            lConsole.Text = "Console";
            // 
            // pConsole
            // 
            pConsole.AutoSize = true;
            pConsole.Controls.Add(tbConsole);
            pConsole.Controls.Add(lConsole);
            pConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            pConsole.Location = new Point(0, 28);
            pConsole.Name = "pConsole";
            pConsole.Size = new Size(702, 381);
            pConsole.TabIndex = 3;
            // 
            // pInput
            // 
            pInput.Controls.Add(bDisconnect);
            pInput.Controls.Add(bLoad);
            pInput.Controls.Add(lFileName);
            pInput.Controls.Add(lBaudRate);
            pInput.Controls.Add(tbLayout);
            pInput.Controls.Add(tbBaudRate);
            pInput.Controls.Add(lPorts);
            pInput.Controls.Add(cbPorts);
            pInput.Controls.Add(bConnect);
            pInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            pInput.Location = new Point(0, 300);
            pInput.Name = "pInput";
            pInput.Size = new Size(702, 109);
            pInput.TabIndex = 4;
            // 
            // bDisconnect
            // 
            bDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bDisconnect.Location = new Point(23, 23);
            bDisconnect.Name = "bDisconnect";
            bDisconnect.Size = new Size(116, 44);
            bDisconnect.TabIndex = 8;
            bDisconnect.Text = "Disconnect";
            bDisconnect.UseVisualStyleBackColor = true;
            bDisconnect.Click += bDisconnect_Click;
            // 
            // bLoad
            // 
            bLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            bLoad.Location = new Point(452, 65);
            bLoad.Name = "bLoad";
            bLoad.Size = new Size(94, 32);
            bLoad.TabIndex = 7;
            bLoad.Text = "Load";
            bLoad.UseVisualStyleBackColor = true;
            bLoad.Click += bLoad_Click;
            // 
            // lFileName
            // 
            lFileName.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lFileName.AutoSize = true;
            lFileName.Location = new Point(452, 9);
            lFileName.Name = "lFileName";
            lFileName.Size = new Size(76, 20);
            lFileName.TabIndex = 6;
            lFileName.Text = "File Name";
            // 
            // lBaudRate
            // 
            lBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lBaudRate.AutoSize = true;
            lBaudRate.Location = new Point(321, 9);
            lBaudRate.Name = "lBaudRate";
            lBaudRate.Size = new Size(73, 20);
            lBaudRate.TabIndex = 5;
            lBaudRate.Text = "BaudRate";
            // 
            // tbLayout
            // 
            tbLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tbLayout.Location = new Point(452, 32);
            tbLayout.Name = "tbLayout";
            tbLayout.Size = new Size(214, 27);
            tbLayout.TabIndex = 4;
            // 
            // tbBaudRate
            // 
            tbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tbBaudRate.Location = new Point(321, 32);
            tbBaudRate.Name = "tbBaudRate";
            tbBaudRate.Size = new Size(125, 27);
            tbBaudRate.TabIndex = 3;
            tbBaudRate.TextChanged += tbBaudRate_TextChanged;
            // 
            // lPorts
            // 
            lPorts.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lPorts.AutoSize = true;
            lPorts.Location = new Point(182, 9);
            lPorts.Name = "lPorts";
            lPorts.Size = new Size(107, 20);
            lPorts.TabIndex = 2;
            lPorts.Text = "Available Ports";
            // 
            // cbPorts
            // 
            cbPorts.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cbPorts.FormattingEnabled = true;
            cbPorts.Location = new Point(182, 32);
            cbPorts.Name = "cbPorts";
            cbPorts.Size = new Size(133, 28);
            cbPorts.TabIndex = 1;
            cbPorts.SelectedIndexChanged += cbPorts_SelectedIndexChanged;
            // 
            // bConnect
            // 
            bConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bConnect.Location = new Point(23, 23);
            bConnect.Name = "bConnect";
            bConnect.Size = new Size(116, 44);
            bConnect.TabIndex = 0;
            bConnect.Text = "Connect";
            bConnect.UseVisualStyleBackColor = true;
            bConnect.Click += bConnect_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "MacroDriver";
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            // 
            // iconMenuStrip
            // 
            iconMenuStrip.ImageScalingSize = new Size(20, 20);
            iconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miOpen, miExit });
            iconMenuStrip.Name = "iconMenuStrip";
            iconMenuStrip.Size = new Size(115, 52);
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(114, 24);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(114, 24);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // MacroDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(702, 409);
            Controls.Add(pInput);
            Controls.Add(pConsole);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(720, 456);
            Name = "MacroDriver";
            Text = "MacroDriver";
            Activated += MacroDriver_Activated;
            FormClosing += MacroDriver_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pConsole.ResumeLayout(false);
            pConsole.PerformLayout();
            pInput.ResumeLayout(false);
            pInput.PerformLayout();
            iconMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.Label lConsole;
        private System.Windows.Forms.Panel pConsole;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.Label lBaudRate;
        private System.Windows.Forms.TextBox tbLayout;
        private System.Windows.Forms.TextBox tbBaudRate;
        private System.Windows.Forms.Label lPorts;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip iconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button bDisconnect;

        public System.Windows.Forms.TextBox Console
        {
            get { return this.tbConsole; }
        }
    }
}
