namespace MacroDriver
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lDefaulFile = new System.Windows.Forms.Label();
            this.pSettings = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.chRemainOpen = new System.Windows.Forms.CheckBox();
            this.chConnectAutomatically = new System.Windows.Forms.CheckBox();
            this.cbSequenceMode = new System.Windows.Forms.ComboBox();
            this.tbDefaultPort = new System.Windows.Forms.TextBox();
            this.tbDefaultBaudRate = new System.Windows.Forms.TextBox();
            this.tbDefaultFile = new System.Windows.Forms.TextBox();
            this.lRemainOpen = new System.Windows.Forms.Label();
            this.lConnectAutomatically = new System.Windows.Forms.Label();
            this.lSequenceMode = new System.Windows.Forms.Label();
            this.lDefaultPort = new System.Windows.Forms.Label();
            this.lDefaultBaudRate = new System.Windows.Forms.Label();
            this.pSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDefaulFile
            // 
            this.lDefaulFile.AutoSize = true;
            this.lDefaulFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDefaulFile.Location = new System.Drawing.Point(40, 30);
            this.lDefaulFile.Name = "lDefaulFile";
            this.lDefaulFile.Size = new System.Drawing.Size(103, 23);
            this.lDefaulFile.TabIndex = 0;
            this.lDefaulFile.Text = "Default File";
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.bCancel);
            this.pSettings.Controls.Add(this.bOK);
            this.pSettings.Controls.Add(this.chRemainOpen);
            this.pSettings.Controls.Add(this.chConnectAutomatically);
            this.pSettings.Controls.Add(this.cbSequenceMode);
            this.pSettings.Controls.Add(this.tbDefaultPort);
            this.pSettings.Controls.Add(this.tbDefaultBaudRate);
            this.pSettings.Controls.Add(this.tbDefaultFile);
            this.pSettings.Controls.Add(this.lRemainOpen);
            this.pSettings.Controls.Add(this.lConnectAutomatically);
            this.pSettings.Controls.Add(this.lSequenceMode);
            this.pSettings.Controls.Add(this.lDefaultPort);
            this.pSettings.Controls.Add(this.lDefaultBaudRate);
            this.pSettings.Controls.Add(this.lDefaulFile);
            this.pSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSettings.Location = new System.Drawing.Point(0, 0);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(800, 450);
            this.pSettings.TabIndex = 6;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(577, 339);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(94, 29);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.Location = new System.Drawing.Point(399, 339);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(94, 29);
            this.bOK.TabIndex = 12;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // chRemainOpen
            // 
            this.chRemainOpen.AutoSize = true;
            this.chRemainOpen.Location = new System.Drawing.Point(258, 326);
            this.chRemainOpen.Name = "chRemainOpen";
            this.chRemainOpen.Size = new System.Drawing.Size(18, 17);
            this.chRemainOpen.TabIndex = 11;
            this.chRemainOpen.UseVisualStyleBackColor = true;
            // 
            // chConnectAutomatically
            // 
            this.chConnectAutomatically.AutoSize = true;
            this.chConnectAutomatically.Location = new System.Drawing.Point(258, 267);
            this.chConnectAutomatically.Name = "chConnectAutomatically";
            this.chConnectAutomatically.Size = new System.Drawing.Size(18, 17);
            this.chConnectAutomatically.TabIndex = 10;
            this.chConnectAutomatically.UseVisualStyleBackColor = true;
            // 
            // cbSequenceMode
            // 
            this.cbSequenceMode.FormattingEnabled = true;
            this.cbSequenceMode.Location = new System.Drawing.Point(258, 199);
            this.cbSequenceMode.Name = "cbSequenceMode";
            this.cbSequenceMode.Size = new System.Drawing.Size(151, 28);
            this.cbSequenceMode.TabIndex = 9;
            // 
            // tbDefaultPort
            // 
            this.tbDefaultPort.Location = new System.Drawing.Point(258, 142);
            this.tbDefaultPort.Name = "tbDefaultPort";
            this.tbDefaultPort.Size = new System.Drawing.Size(235, 27);
            this.tbDefaultPort.TabIndex = 8;
            // 
            // tbDefaultBaudRate
            // 
            this.tbDefaultBaudRate.Location = new System.Drawing.Point(258, 84);
            this.tbDefaultBaudRate.Name = "tbDefaultBaudRate";
            this.tbDefaultBaudRate.Size = new System.Drawing.Size(235, 27);
            this.tbDefaultBaudRate.TabIndex = 7;
            // 
            // tbDefaultFile
            // 
            this.tbDefaultFile.Location = new System.Drawing.Point(258, 26);
            this.tbDefaultFile.Name = "tbDefaultFile";
            this.tbDefaultFile.Size = new System.Drawing.Size(235, 27);
            this.tbDefaultFile.TabIndex = 6;
            // 
            // lRemainOpen
            // 
            this.lRemainOpen.AutoSize = true;
            this.lRemainOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lRemainOpen.Location = new System.Drawing.Point(40, 320);
            this.lRemainOpen.Name = "lRemainOpen";
            this.lRemainOpen.Size = new System.Drawing.Size(182, 23);
            this.lRemainOpen.TabIndex = 5;
            this.lRemainOpen.Text = "Remain Open on Tray";
            // 
            // lConnectAutomatically
            // 
            this.lConnectAutomatically.AutoSize = true;
            this.lConnectAutomatically.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lConnectAutomatically.Location = new System.Drawing.Point(40, 262);
            this.lConnectAutomatically.Name = "lConnectAutomatically";
            this.lConnectAutomatically.Size = new System.Drawing.Size(192, 23);
            this.lConnectAutomatically.TabIndex = 4;
            this.lConnectAutomatically.Text = "Connect Automatically";
            // 
            // lSequenceMode
            // 
            this.lSequenceMode.AutoSize = true;
            this.lSequenceMode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSequenceMode.Location = new System.Drawing.Point(40, 204);
            this.lSequenceMode.Name = "lSequenceMode";
            this.lSequenceMode.Size = new System.Drawing.Size(56, 23);
            this.lSequenceMode.TabIndex = 3;
            this.lSequenceMode.Text = "Mode";
            // 
            // lDefaultPort
            // 
            this.lDefaultPort.AutoSize = true;
            this.lDefaultPort.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDefaultPort.Location = new System.Drawing.Point(40, 146);
            this.lDefaultPort.Name = "lDefaultPort";
            this.lDefaultPort.Size = new System.Drawing.Size(108, 23);
            this.lDefaultPort.TabIndex = 2;
            this.lDefaultPort.Text = "Default Port";
            // 
            // lDefaultBaudRate
            // 
            this.lDefaultBaudRate.AutoSize = true;
            this.lDefaultBaudRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDefaultBaudRate.Location = new System.Drawing.Point(40, 88);
            this.lDefaultBaudRate.Name = "lDefaultBaudRate";
            this.lDefaultBaudRate.Size = new System.Drawing.Size(157, 23);
            this.lDefaultBaudRate.TabIndex = 1;
            this.lDefaultBaudRate.Text = "Default Baud Rate";
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lDefaulFile;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.TextBox tbDefaultFile;
        private System.Windows.Forms.Label lRemainOpen;
        private System.Windows.Forms.Label lConnectAutomatically;
        private System.Windows.Forms.Label lSequenceMode;
        private System.Windows.Forms.Label lDefaultPort;
        private System.Windows.Forms.Label lDefaultBaudRate;
        private System.Windows.Forms.TextBox tbDefaultBaudRate;
        private System.Windows.Forms.ComboBox cbSequenceMode;
        private System.Windows.Forms.TextBox tbDefaultPort;
        private System.Windows.Forms.CheckBox chRemainOpen;
        private System.Windows.Forms.CheckBox chConnectAutomatically;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
    }
}