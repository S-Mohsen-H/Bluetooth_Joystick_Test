namespace Bluetooth_Joystick_Test
{
    partial class UART_Decode_0x1A
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxReceivedData = new System.Windows.Forms.CheckBox();
            this.textBoxReceivedData = new System.Windows.Forms.TextBox();
            this.labelCOMStatus = new System.Windows.Forms.Label();
            this.timerAutoDetectPort = new System.Windows.Forms.Timer(this.components);
            this.buttonStatus = new System.Windows.Forms.Button();
            this.textBoxLastDataString = new System.Windows.Forms.TextBox();
            this.buttonHide = new System.Windows.Forms.Button();
            this.textBoxCommandQueue = new System.Windows.Forms.TextBox();
            this.timerSendCommand = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerFindPort = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer200msec = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkBoxReceivedData
            // 
            this.checkBoxReceivedData.AutoSize = true;
            this.checkBoxReceivedData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(146)))), ((int)(((byte)(53)))));
            this.checkBoxReceivedData.Location = new System.Drawing.Point(12, 175);
            this.checkBoxReceivedData.Name = "checkBoxReceivedData";
            this.checkBoxReceivedData.Size = new System.Drawing.Size(98, 17);
            this.checkBoxReceivedData.TabIndex = 11;
            this.checkBoxReceivedData.Text = "Received Data";
            this.checkBoxReceivedData.UseVisualStyleBackColor = true;
            // 
            // textBoxReceivedData
            // 
            this.textBoxReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceivedData.Location = new System.Drawing.Point(12, 197);
            this.textBoxReceivedData.Multiline = true;
            this.textBoxReceivedData.Name = "textBoxReceivedData";
            this.textBoxReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceivedData.Size = new System.Drawing.Size(1063, 370);
            this.textBoxReceivedData.TabIndex = 10;
            // 
            // labelCOMStatus
            // 
            this.labelCOMStatus.AutoSize = true;
            this.labelCOMStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(146)))), ((int)(((byte)(53)))));
            this.labelCOMStatus.Location = new System.Drawing.Point(98, 12);
            this.labelCOMStatus.Name = "labelCOMStatus";
            this.labelCOMStatus.Size = new System.Drawing.Size(16, 13);
            this.labelCOMStatus.TabIndex = 13;
            this.labelCOMStatus.Text = "...";
            // 
            // timerAutoDetectPort
            // 
            this.timerAutoDetectPort.Interval = 200;
            this.timerAutoDetectPort.Tick += new System.EventHandler(this.timerAutoDetectPort_Tick);
            // 
            // buttonStatus
            // 
            this.buttonStatus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStatus.Enabled = false;
            this.buttonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus.Location = new System.Drawing.Point(12, 7);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(76, 23);
            this.buttonStatus.TabIndex = 14;
            this.buttonStatus.UseVisualStyleBackColor = false;
            this.buttonStatus.BackColorChanged += new System.EventHandler(this.buttonStatus_BackColorChanged);
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // textBoxLastDataString
            // 
            this.textBoxLastDataString.Location = new System.Drawing.Point(11, 38);
            this.textBoxLastDataString.Multiline = true;
            this.textBoxLastDataString.Name = "textBoxLastDataString";
            this.textBoxLastDataString.Size = new System.Drawing.Size(373, 132);
            this.textBoxLastDataString.TabIndex = 15;
            // 
            // buttonHide
            // 
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(146)))), ((int)(((byte)(53)))));
            this.buttonHide.Location = new System.Drawing.Point(981, 7);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(75, 23);
            this.buttonHide.TabIndex = 16;
            this.buttonHide.Text = "Hide!";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // textBoxCommandQueue
            // 
            this.textBoxCommandQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandQueue.Location = new System.Drawing.Point(392, 38);
            this.textBoxCommandQueue.Multiline = true;
            this.textBoxCommandQueue.Name = "textBoxCommandQueue";
            this.textBoxCommandQueue.Size = new System.Drawing.Size(683, 132);
            this.textBoxCommandQueue.TabIndex = 17;
            // 
            // timerSendCommand
            // 
            this.timerSendCommand.Interval = 1000;
            this.timerSendCommand.Tick += new System.EventHandler(this.timerSendCommand_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(314, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(651, 17);
            this.progressBar1.TabIndex = 18;
            // 
            // timerFindPort
            // 
            this.timerFindPort.Interval = 2000;
            this.timerFindPort.Tick += new System.EventHandler(this.timerFindPort_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(146)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(116, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // timer200msec
            // 
            this.timer200msec.Interval = 200;
            this.timer200msec.Tick += new System.EventHandler(this.timer200msec_Tick);
            // 
            // UART_Decode_0x1A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1086, 579);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxCommandQueue);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.textBoxLastDataString);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.labelCOMStatus);
            this.Controls.Add(this.checkBoxReceivedData);
            this.Controls.Add(this.textBoxReceivedData);
            this.Name = "UART_Decode_0x1A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Communication Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCommunicationPanel_FormClosing);
            this.Load += new System.EventHandler(this.UART_Decode_0x1A_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxReceivedData;
        private System.Windows.Forms.TextBox textBoxReceivedData;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label labelCOMStatus;
        private System.Windows.Forms.Timer timerAutoDetectPort;
        private System.Windows.Forms.TextBox textBoxLastDataString;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.TextBox textBoxCommandQueue;
        private System.Windows.Forms.Timer timerSendCommand;
        public System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Timer timerFindPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer200msec;
        public System.Windows.Forms.ProgressBar progressBar1;

    }
}