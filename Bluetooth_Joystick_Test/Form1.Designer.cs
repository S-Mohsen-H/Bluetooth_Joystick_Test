namespace Bluetooth_Joystick_Test
{
    partial class Form1
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
            this.textBox_COMPort = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.timer_updateChart = new System.Windows.Forms.Timer(this.components);
            this.textBox_byte0 = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.serialBT = new System.IO.Ports.SerialPort(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.joystickChart = new Joystick_2023_Control.Joystick_2023();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBox_samplingRate = new System.Windows.Forms.TextBox();
            this.label_COMMAND_BYTE_INDEX = new System.Windows.Forms.Label();
            this.label_COMPort = new System.Windows.Forms.Label();
            this.label_customMessage = new System.Windows.Forms.Label();
            this.button_applySampleRate = new System.Windows.Forms.Button();
            this.label_helpSamplingRate = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_samplingRate = new System.Windows.Forms.Label();
            this.button_heartRate = new System.Windows.Forms.Button();
            this.textBox_byte1 = new System.Windows.Forms.TextBox();
            this.textBox_byte2 = new System.Windows.Forms.TextBox();
            this.textBox_byte3 = new System.Windows.Forms.TextBox();
            this.textBox_byte4 = new System.Windows.Forms.TextBox();
            this.textBox_byte6 = new System.Windows.Forms.TextBox();
            this.textBox_byte5 = new System.Windows.Forms.TextBox();
            this.textBox_byte7 = new System.Windows.Forms.TextBox();
            this.textBox_byte8 = new System.Windows.Forms.TextBox();
            this.textBox_byte9 = new System.Windows.Forms.TextBox();
            this.textBox_byte10 = new System.Windows.Forms.TextBox();
            this.textBox_byte11 = new System.Windows.Forms.TextBox();
            this.textBox_byte12 = new System.Windows.Forms.TextBox();
            this.textBox_byte13 = new System.Windows.Forms.TextBox();
            this.textBox_byte14 = new System.Windows.Forms.TextBox();
            this.textBox_byte15 = new System.Windows.Forms.TextBox();
            this.label_byte1 = new System.Windows.Forms.Label();
            this.label_byte2 = new System.Windows.Forms.Label();
            this.label_byte3 = new System.Windows.Forms.Label();
            this.label_byte4 = new System.Windows.Forms.Label();
            this.label_byte5 = new System.Windows.Forms.Label();
            this.label_byte6 = new System.Windows.Forms.Label();
            this.label_byte7 = new System.Windows.Forms.Label();
            this.label_byte8 = new System.Windows.Forms.Label();
            this.label_byte9 = new System.Windows.Forms.Label();
            this.label_byte10 = new System.Windows.Forms.Label();
            this.label_byte11 = new System.Windows.Forms.Label();
            this.label_byte12 = new System.Windows.Forms.Label();
            this.label_byte13 = new System.Windows.Forms.Label();
            this.label_byte14 = new System.Windows.Forms.Label();
            this.label_byte15 = new System.Windows.Forms.Label();
            this.label_byte0 = new System.Windows.Forms.Label();
            this.label_filterCoefficient = new System.Windows.Forms.Label();
            this.button_applyFilterCoefficient = new System.Windows.Forms.Button();
            this.textBox_filterCoefficient = new System.Windows.Forms.TextBox();
            this.label_helpSamplingCoefficient = new System.Windows.Forms.Label();
            this.button_LED = new System.Windows.Forms.Button();
            this.textBox_alarmPatternBin = new System.Windows.Forms.TextBox();
            this.textBox_alarmPatternHex = new System.Windows.Forms.TextBox();
            this.button_alarmBin = new System.Windows.Forms.Button();
            this.button_alarmHex = new System.Windows.Forms.Button();
            this.comboBox_alarmCountBin = new System.Windows.Forms.ComboBox();
            this.comboBox_alarmCountHex = new System.Windows.Forms.ComboBox();
            this.label_XOut = new System.Windows.Forms.Label();
            this.label_YOut = new System.Windows.Forms.Label();
            this.label_ZOut = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_autoDetectCOMPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_COMPort
            // 
            this.textBox_COMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_COMPort.Location = new System.Drawing.Point(489, 449);
            this.textBox_COMPort.Name = "textBox_COMPort";
            this.textBox_COMPort.Size = new System.Drawing.Size(100, 27);
            this.textBox_COMPort.TabIndex = 1;
            this.textBox_COMPort.Text = "COM11";
            this.textBox_COMPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.OrangeRed;
            this.button_connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_connect.Location = new System.Drawing.Point(0, 482);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(1084, 40);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // timer_updateChart
            // 
            this.timer_updateChart.Tick += new System.EventHandler(this.timer_updateChart_Tick);
            // 
            // textBox_byte0
            // 
            this.textBox_byte0.Enabled = false;
            this.textBox_byte0.Location = new System.Drawing.Point(105, 399);
            this.textBox_byte0.Name = "textBox_byte0";
            this.textBox_byte0.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte0.TabIndex = 4;
            this.textBox_byte0.Text = "Reserved";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(905, 397);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // serialBT
            // 
            this.serialBT.BaudRate = 115200;
            this.serialBT.PortName = "COM5";
            this.serialBT.ReceivedBytesThreshold = 16;
            this.serialBT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(369, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "button";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // joystickChart
            // 
            this.joystickChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.joystickChart.Button = false;
            this.joystickChart.Joystick_Mode_Flag = ((byte)(0));
            this.joystickChart.Location = new System.Drawing.Point(12, 12);
            this.joystickChart.Name = "joystickChart";
            this.joystickChart.SamplingRateMS = 100;
            this.joystickChart.Size = new System.Drawing.Size(351, 350);
            this.joystickChart.TabIndex = 3;
            this.joystickChart.Title_Name = null;
            this.joystickChart.X_Dead_Band = 50D;
            this.joystickChart.X_Input = 0D;
            this.joystickChart.X_Max_Minus = 0D;
            this.joystickChart.X_Max_Plus = 0D;
            this.joystickChart.X_Offset_Minus = 0D;
            this.joystickChart.X_Offset_Plus = 0D;
            this.joystickChart.X_Output = 0D;
            this.joystickChart.X_Slope_Minus = 0D;
            this.joystickChart.X_Slope_Plus = 0D;
            this.joystickChart.Y_Dead_Band = 50D;
            this.joystickChart.Y_Input = 0D;
            this.joystickChart.Y_Max_Minus = 0D;
            this.joystickChart.Y_Max_Plus = 0D;
            this.joystickChart.Y_Offset_Minus = 0D;
            this.joystickChart.Y_Offset_Plus = 0D;
            this.joystickChart.Y_Output = 0D;
            this.joystickChart.Y_Slope_Minus = 0D;
            this.joystickChart.Y_Slope_Plus = 0D;
            this.joystickChart.Z_Dead_Band = 50D;
            this.joystickChart.Z_Input = 0D;
            this.joystickChart.Z_Max_Minus = 0D;
            this.joystickChart.Z_Max_Plus = 0D;
            this.joystickChart.Z_Offset_Minus = 0D;
            this.joystickChart.Z_Offset_Plus = 0D;
            this.joystickChart.Z_Output = 0D;
            this.joystickChart.Z_Slope_Minus = 0D;
            this.joystickChart.Z_Slope_Plus = 0D;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(366, 37);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(14, 13);
            this.label_X.TabIndex = 7;
            this.label_X.Text = "X";
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(366, 63);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 13);
            this.label_Z.TabIndex = 7;
            this.label_Z.Text = "Z";
            // 
            // textBox_samplingRate
            // 
            this.textBox_samplingRate.Location = new System.Drawing.Point(465, 128);
            this.textBox_samplingRate.Name = "textBox_samplingRate";
            this.textBox_samplingRate.Size = new System.Drawing.Size(58, 20);
            this.textBox_samplingRate.TabIndex = 8;
            this.textBox_samplingRate.Text = "5";
            // 
            // label_COMMAND_BYTE_INDEX
            // 
            this.label_COMMAND_BYTE_INDEX.AutoSize = true;
            this.label_COMMAND_BYTE_INDEX.Location = new System.Drawing.Point(369, 131);
            this.label_COMMAND_BYTE_INDEX.Name = "label_COMMAND_BYTE_INDEX";
            this.label_COMMAND_BYTE_INDEX.Size = new System.Drawing.Size(74, 13);
            this.label_COMMAND_BYTE_INDEX.TabIndex = 9;
            this.label_COMMAND_BYTE_INDEX.Text = "Sample Rate :";
            // 
            // label_COMPort
            // 
            this.label_COMPort.AutoSize = true;
            this.label_COMPort.Location = new System.Drawing.Point(424, 457);
            this.label_COMPort.Name = "label_COMPort";
            this.label_COMPort.Size = new System.Drawing.Size(59, 13);
            this.label_COMPort.TabIndex = 10;
            this.label_COMPort.Text = "COM Port :";
            // 
            // label_customMessage
            // 
            this.label_customMessage.AutoSize = true;
            this.label_customMessage.Location = new System.Drawing.Point(3, 402);
            this.label_customMessage.Name = "label_customMessage";
            this.label_customMessage.Size = new System.Drawing.Size(94, 13);
            this.label_customMessage.TabIndex = 11;
            this.label_customMessage.Text = "Custom Message :";
            // 
            // button_applySampleRate
            // 
            this.button_applySampleRate.Location = new System.Drawing.Point(529, 126);
            this.button_applySampleRate.Name = "button_applySampleRate";
            this.button_applySampleRate.Size = new System.Drawing.Size(75, 23);
            this.button_applySampleRate.TabIndex = 5;
            this.button_applySampleRate.Text = "Apply";
            this.button_applySampleRate.UseVisualStyleBackColor = true;
            this.button_applySampleRate.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label_helpSamplingRate
            // 
            this.label_helpSamplingRate.AutoSize = true;
            this.label_helpSamplingRate.Location = new System.Drawing.Point(610, 131);
            this.label_helpSamplingRate.Name = "label_helpSamplingRate";
            this.label_helpSamplingRate.Size = new System.Drawing.Size(231, 13);
            this.label_helpSamplingRate.TabIndex = 9;
            this.label_helpSamplingRate.Text = "Sampling rate will be 10 times the entered value";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(366, 50);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 13);
            this.label_Y.TabIndex = 12;
            this.label_Y.Text = "Y";
            // 
            // label_samplingRate
            // 
            this.label_samplingRate.AutoSize = true;
            this.label_samplingRate.Location = new System.Drawing.Point(366, 99);
            this.label_samplingRate.Name = "label_samplingRate";
            this.label_samplingRate.Size = new System.Drawing.Size(76, 13);
            this.label_samplingRate.TabIndex = 13;
            this.label_samplingRate.Text = "Sampling Rate";
            // 
            // button_heartRate
            // 
            this.button_heartRate.Location = new System.Drawing.Point(369, 12);
            this.button_heartRate.Name = "button_heartRate";
            this.button_heartRate.Size = new System.Drawing.Size(75, 23);
            this.button_heartRate.TabIndex = 14;
            this.button_heartRate.Text = "Alive";
            this.button_heartRate.UseVisualStyleBackColor = true;
            // 
            // textBox_byte1
            // 
            this.textBox_byte1.Location = new System.Drawing.Point(155, 399);
            this.textBox_byte1.Name = "textBox_byte1";
            this.textBox_byte1.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte1.TabIndex = 15;
            this.textBox_byte1.Text = "0";
            // 
            // textBox_byte2
            // 
            this.textBox_byte2.Location = new System.Drawing.Point(205, 399);
            this.textBox_byte2.Name = "textBox_byte2";
            this.textBox_byte2.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte2.TabIndex = 4;
            this.textBox_byte2.Text = "0";
            // 
            // textBox_byte3
            // 
            this.textBox_byte3.Location = new System.Drawing.Point(255, 399);
            this.textBox_byte3.Name = "textBox_byte3";
            this.textBox_byte3.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte3.TabIndex = 15;
            this.textBox_byte3.Text = "0";
            // 
            // textBox_byte4
            // 
            this.textBox_byte4.Location = new System.Drawing.Point(305, 399);
            this.textBox_byte4.Name = "textBox_byte4";
            this.textBox_byte4.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte4.TabIndex = 4;
            this.textBox_byte4.Text = "0";
            // 
            // textBox_byte6
            // 
            this.textBox_byte6.Location = new System.Drawing.Point(405, 399);
            this.textBox_byte6.Name = "textBox_byte6";
            this.textBox_byte6.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte6.TabIndex = 4;
            this.textBox_byte6.Text = "0";
            // 
            // textBox_byte5
            // 
            this.textBox_byte5.Location = new System.Drawing.Point(355, 399);
            this.textBox_byte5.Name = "textBox_byte5";
            this.textBox_byte5.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte5.TabIndex = 15;
            this.textBox_byte5.Text = "0";
            // 
            // textBox_byte7
            // 
            this.textBox_byte7.Location = new System.Drawing.Point(455, 399);
            this.textBox_byte7.Name = "textBox_byte7";
            this.textBox_byte7.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte7.TabIndex = 15;
            this.textBox_byte7.Text = "0";
            // 
            // textBox_byte8
            // 
            this.textBox_byte8.Location = new System.Drawing.Point(505, 399);
            this.textBox_byte8.Name = "textBox_byte8";
            this.textBox_byte8.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte8.TabIndex = 4;
            this.textBox_byte8.Text = "0";
            // 
            // textBox_byte9
            // 
            this.textBox_byte9.Location = new System.Drawing.Point(555, 399);
            this.textBox_byte9.Name = "textBox_byte9";
            this.textBox_byte9.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte9.TabIndex = 4;
            this.textBox_byte9.Text = "0";
            // 
            // textBox_byte10
            // 
            this.textBox_byte10.Location = new System.Drawing.Point(605, 399);
            this.textBox_byte10.Name = "textBox_byte10";
            this.textBox_byte10.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte10.TabIndex = 4;
            this.textBox_byte10.Text = "0";
            // 
            // textBox_byte11
            // 
            this.textBox_byte11.Location = new System.Drawing.Point(655, 399);
            this.textBox_byte11.Name = "textBox_byte11";
            this.textBox_byte11.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte11.TabIndex = 4;
            this.textBox_byte11.Text = "0";
            // 
            // textBox_byte12
            // 
            this.textBox_byte12.Location = new System.Drawing.Point(705, 399);
            this.textBox_byte12.Name = "textBox_byte12";
            this.textBox_byte12.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte12.TabIndex = 15;
            this.textBox_byte12.Text = "0";
            // 
            // textBox_byte13
            // 
            this.textBox_byte13.Location = new System.Drawing.Point(755, 399);
            this.textBox_byte13.Name = "textBox_byte13";
            this.textBox_byte13.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte13.TabIndex = 15;
            this.textBox_byte13.Text = "0";
            // 
            // textBox_byte14
            // 
            this.textBox_byte14.Location = new System.Drawing.Point(805, 400);
            this.textBox_byte14.Name = "textBox_byte14";
            this.textBox_byte14.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte14.TabIndex = 15;
            this.textBox_byte14.Text = "0";
            // 
            // textBox_byte15
            // 
            this.textBox_byte15.Location = new System.Drawing.Point(855, 399);
            this.textBox_byte15.Name = "textBox_byte15";
            this.textBox_byte15.Size = new System.Drawing.Size(44, 20);
            this.textBox_byte15.TabIndex = 15;
            this.textBox_byte15.Text = "0";
            // 
            // label_byte1
            // 
            this.label_byte1.AutoSize = true;
            this.label_byte1.Location = new System.Drawing.Point(152, 383);
            this.label_byte1.Name = "label_byte1";
            this.label_byte1.Size = new System.Drawing.Size(37, 13);
            this.label_byte1.TabIndex = 16;
            this.label_byte1.Text = "Byte 1";
            // 
            // label_byte2
            // 
            this.label_byte2.AutoSize = true;
            this.label_byte2.Location = new System.Drawing.Point(202, 383);
            this.label_byte2.Name = "label_byte2";
            this.label_byte2.Size = new System.Drawing.Size(37, 13);
            this.label_byte2.TabIndex = 16;
            this.label_byte2.Text = "Byte 2";
            // 
            // label_byte3
            // 
            this.label_byte3.AutoSize = true;
            this.label_byte3.Location = new System.Drawing.Point(252, 383);
            this.label_byte3.Name = "label_byte3";
            this.label_byte3.Size = new System.Drawing.Size(37, 13);
            this.label_byte3.TabIndex = 16;
            this.label_byte3.Text = "Byte 3";
            // 
            // label_byte4
            // 
            this.label_byte4.AutoSize = true;
            this.label_byte4.Location = new System.Drawing.Point(302, 383);
            this.label_byte4.Name = "label_byte4";
            this.label_byte4.Size = new System.Drawing.Size(37, 13);
            this.label_byte4.TabIndex = 16;
            this.label_byte4.Text = "Byte 4";
            // 
            // label_byte5
            // 
            this.label_byte5.AutoSize = true;
            this.label_byte5.Location = new System.Drawing.Point(352, 383);
            this.label_byte5.Name = "label_byte5";
            this.label_byte5.Size = new System.Drawing.Size(37, 13);
            this.label_byte5.TabIndex = 16;
            this.label_byte5.Text = "Byte 5";
            // 
            // label_byte6
            // 
            this.label_byte6.AutoSize = true;
            this.label_byte6.Location = new System.Drawing.Point(402, 383);
            this.label_byte6.Name = "label_byte6";
            this.label_byte6.Size = new System.Drawing.Size(37, 13);
            this.label_byte6.TabIndex = 16;
            this.label_byte6.Text = "Byte 6";
            // 
            // label_byte7
            // 
            this.label_byte7.AutoSize = true;
            this.label_byte7.Location = new System.Drawing.Point(452, 383);
            this.label_byte7.Name = "label_byte7";
            this.label_byte7.Size = new System.Drawing.Size(37, 13);
            this.label_byte7.TabIndex = 16;
            this.label_byte7.Text = "Byte 7";
            // 
            // label_byte8
            // 
            this.label_byte8.AutoSize = true;
            this.label_byte8.Location = new System.Drawing.Point(502, 383);
            this.label_byte8.Name = "label_byte8";
            this.label_byte8.Size = new System.Drawing.Size(37, 13);
            this.label_byte8.TabIndex = 16;
            this.label_byte8.Text = "Byte 8";
            // 
            // label_byte9
            // 
            this.label_byte9.AutoSize = true;
            this.label_byte9.Location = new System.Drawing.Point(552, 383);
            this.label_byte9.Name = "label_byte9";
            this.label_byte9.Size = new System.Drawing.Size(37, 13);
            this.label_byte9.TabIndex = 16;
            this.label_byte9.Text = "Byte 9";
            // 
            // label_byte10
            // 
            this.label_byte10.AutoSize = true;
            this.label_byte10.Location = new System.Drawing.Point(602, 383);
            this.label_byte10.Name = "label_byte10";
            this.label_byte10.Size = new System.Drawing.Size(43, 13);
            this.label_byte10.TabIndex = 16;
            this.label_byte10.Text = "Byte 10";
            // 
            // label_byte11
            // 
            this.label_byte11.AutoSize = true;
            this.label_byte11.Location = new System.Drawing.Point(652, 383);
            this.label_byte11.Name = "label_byte11";
            this.label_byte11.Size = new System.Drawing.Size(43, 13);
            this.label_byte11.TabIndex = 16;
            this.label_byte11.Text = "Byte 11";
            // 
            // label_byte12
            // 
            this.label_byte12.AutoSize = true;
            this.label_byte12.Location = new System.Drawing.Point(702, 383);
            this.label_byte12.Name = "label_byte12";
            this.label_byte12.Size = new System.Drawing.Size(43, 13);
            this.label_byte12.TabIndex = 16;
            this.label_byte12.Text = "Byte 12";
            // 
            // label_byte13
            // 
            this.label_byte13.AutoSize = true;
            this.label_byte13.Location = new System.Drawing.Point(752, 383);
            this.label_byte13.Name = "label_byte13";
            this.label_byte13.Size = new System.Drawing.Size(43, 13);
            this.label_byte13.TabIndex = 16;
            this.label_byte13.Text = "Byte 13";
            // 
            // label_byte14
            // 
            this.label_byte14.AutoSize = true;
            this.label_byte14.Location = new System.Drawing.Point(802, 383);
            this.label_byte14.Name = "label_byte14";
            this.label_byte14.Size = new System.Drawing.Size(43, 13);
            this.label_byte14.TabIndex = 16;
            this.label_byte14.Text = "Byte 14";
            // 
            // label_byte15
            // 
            this.label_byte15.AutoSize = true;
            this.label_byte15.Location = new System.Drawing.Point(852, 383);
            this.label_byte15.Name = "label_byte15";
            this.label_byte15.Size = new System.Drawing.Size(43, 13);
            this.label_byte15.TabIndex = 16;
            this.label_byte15.Text = "Byte 15";
            // 
            // label_byte0
            // 
            this.label_byte0.AutoSize = true;
            this.label_byte0.Location = new System.Drawing.Point(102, 383);
            this.label_byte0.Name = "label_byte0";
            this.label_byte0.Size = new System.Drawing.Size(37, 13);
            this.label_byte0.TabIndex = 16;
            this.label_byte0.Text = "Byte 0";
            // 
            // label_filterCoefficient
            // 
            this.label_filterCoefficient.AutoSize = true;
            this.label_filterCoefficient.Location = new System.Drawing.Point(369, 169);
            this.label_filterCoefficient.Name = "label_filterCoefficient";
            this.label_filterCoefficient.Size = new System.Drawing.Size(88, 13);
            this.label_filterCoefficient.TabIndex = 9;
            this.label_filterCoefficient.Text = "Filter Coefficient :";
            // 
            // button_applyFilterCoefficient
            // 
            this.button_applyFilterCoefficient.Location = new System.Drawing.Point(529, 164);
            this.button_applyFilterCoefficient.Name = "button_applyFilterCoefficient";
            this.button_applyFilterCoefficient.Size = new System.Drawing.Size(75, 23);
            this.button_applyFilterCoefficient.TabIndex = 5;
            this.button_applyFilterCoefficient.Text = "Apply";
            this.button_applyFilterCoefficient.UseVisualStyleBackColor = true;
            this.button_applyFilterCoefficient.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // textBox_filterCoefficient
            // 
            this.textBox_filterCoefficient.Location = new System.Drawing.Point(465, 166);
            this.textBox_filterCoefficient.Name = "textBox_filterCoefficient";
            this.textBox_filterCoefficient.Size = new System.Drawing.Size(58, 20);
            this.textBox_filterCoefficient.TabIndex = 8;
            this.textBox_filterCoefficient.Text = "80";
            // 
            // label_helpSamplingCoefficient
            // 
            this.label_helpSamplingCoefficient.AutoSize = true;
            this.label_helpSamplingCoefficient.Location = new System.Drawing.Point(610, 169);
            this.label_helpSamplingCoefficient.Name = "label_helpSamplingCoefficient";
            this.label_helpSamplingCoefficient.Size = new System.Drawing.Size(236, 13);
            this.label_helpSamplingCoefficient.TabIndex = 9;
            this.label_helpSamplingCoefficient.Text = "Enter the low-pass filter coefficient in percentage";
            // 
            // button_LED
            // 
            this.button_LED.BackColor = System.Drawing.SystemColors.Control;
            this.button_LED.Location = new System.Drawing.Point(529, 203);
            this.button_LED.Name = "button_LED";
            this.button_LED.Size = new System.Drawing.Size(75, 23);
            this.button_LED.TabIndex = 17;
            this.button_LED.Text = "LED";
            this.button_LED.UseVisualStyleBackColor = false;
            this.button_LED.Click += new System.EventHandler(this.button_LED_Click);
            // 
            // textBox_alarmPatternBin
            // 
            this.textBox_alarmPatternBin.Location = new System.Drawing.Point(389, 250);
            this.textBox_alarmPatternBin.Name = "textBox_alarmPatternBin";
            this.textBox_alarmPatternBin.Size = new System.Drawing.Size(238, 20);
            this.textBox_alarmPatternBin.TabIndex = 18;
            this.textBox_alarmPatternBin.Text = "00000000";
            // 
            // textBox_alarmPatternHex
            // 
            this.textBox_alarmPatternHex.Location = new System.Drawing.Point(389, 276);
            this.textBox_alarmPatternHex.Name = "textBox_alarmPatternHex";
            this.textBox_alarmPatternHex.Size = new System.Drawing.Size(110, 20);
            this.textBox_alarmPatternHex.TabIndex = 18;
            this.textBox_alarmPatternHex.Text = "00";
            // 
            // button_alarmBin
            // 
            this.button_alarmBin.Location = new System.Drawing.Point(693, 250);
            this.button_alarmBin.Name = "button_alarmBin";
            this.button_alarmBin.Size = new System.Drawing.Size(75, 23);
            this.button_alarmBin.TabIndex = 5;
            this.button_alarmBin.Text = "Alarm(Bin)";
            this.button_alarmBin.UseVisualStyleBackColor = true;
            this.button_alarmBin.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_alarmHex
            // 
            this.button_alarmHex.Location = new System.Drawing.Point(693, 276);
            this.button_alarmHex.Name = "button_alarmHex";
            this.button_alarmHex.Size = new System.Drawing.Size(75, 23);
            this.button_alarmHex.TabIndex = 5;
            this.button_alarmHex.Text = "Alarm(Hex)";
            this.button_alarmHex.UseVisualStyleBackColor = true;
            this.button_alarmHex.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // comboBox_alarmCountBin
            // 
            this.comboBox_alarmCountBin.FormattingEnabled = true;
            this.comboBox_alarmCountBin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_alarmCountBin.Location = new System.Drawing.Point(633, 250);
            this.comboBox_alarmCountBin.Name = "comboBox_alarmCountBin";
            this.comboBox_alarmCountBin.Size = new System.Drawing.Size(54, 21);
            this.comboBox_alarmCountBin.TabIndex = 19;
            this.comboBox_alarmCountBin.Text = "1";
            // 
            // comboBox_alarmCountHex
            // 
            this.comboBox_alarmCountHex.FormattingEnabled = true;
            this.comboBox_alarmCountHex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_alarmCountHex.Location = new System.Drawing.Point(633, 275);
            this.comboBox_alarmCountHex.Name = "comboBox_alarmCountHex";
            this.comboBox_alarmCountHex.Size = new System.Drawing.Size(54, 21);
            this.comboBox_alarmCountHex.TabIndex = 19;
            this.comboBox_alarmCountHex.Text = "1";
            // 
            // label_XOut
            // 
            this.label_XOut.AutoSize = true;
            this.label_XOut.Location = new System.Drawing.Point(453, 37);
            this.label_XOut.Name = "label_XOut";
            this.label_XOut.Size = new System.Drawing.Size(29, 13);
            this.label_XOut.TabIndex = 20;
            this.label_XOut.Text = "Xout";
            // 
            // label_YOut
            // 
            this.label_YOut.AutoSize = true;
            this.label_YOut.Location = new System.Drawing.Point(453, 50);
            this.label_YOut.Name = "label_YOut";
            this.label_YOut.Size = new System.Drawing.Size(29, 13);
            this.label_YOut.TabIndex = 20;
            this.label_YOut.Text = "Yout";
            // 
            // label_ZOut
            // 
            this.label_ZOut.AutoSize = true;
            this.label_ZOut.Location = new System.Drawing.Point(453, 63);
            this.label_ZOut.Name = "label_ZOut";
            this.label_ZOut.Size = new System.Drawing.Size(29, 13);
            this.label_ZOut.TabIndex = 20;
            this.label_ZOut.Text = "Zout";
            // 
            // button_autoDetectCOMPort
            // 
            this.button_autoDetectCOMPort.Location = new System.Drawing.Point(223, 452);
            this.button_autoDetectCOMPort.Name = "button_autoDetectCOMPort";
            this.button_autoDetectCOMPort.Size = new System.Drawing.Size(126, 23);
            this.button_autoDetectCOMPort.TabIndex = 21;
            this.button_autoDetectCOMPort.Text = "Auto Detect Port";
            this.button_autoDetectCOMPort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 522);
            this.Controls.Add(this.button_autoDetectCOMPort);
            this.Controls.Add(this.label_ZOut);
            this.Controls.Add(this.label_YOut);
            this.Controls.Add(this.label_XOut);
            this.Controls.Add(this.comboBox_alarmCountHex);
            this.Controls.Add(this.comboBox_alarmCountBin);
            this.Controls.Add(this.textBox_alarmPatternHex);
            this.Controls.Add(this.textBox_alarmPatternBin);
            this.Controls.Add(this.button_LED);
            this.Controls.Add(this.label_byte15);
            this.Controls.Add(this.label_byte12);
            this.Controls.Add(this.label_byte11);
            this.Controls.Add(this.label_byte8);
            this.Controls.Add(this.label_byte14);
            this.Controls.Add(this.label_byte7);
            this.Controls.Add(this.label_byte10);
            this.Controls.Add(this.label_byte4);
            this.Controls.Add(this.label_byte13);
            this.Controls.Add(this.label_byte6);
            this.Controls.Add(this.label_byte9);
            this.Controls.Add(this.label_byte3);
            this.Controls.Add(this.label_byte5);
            this.Controls.Add(this.label_byte2);
            this.Controls.Add(this.label_byte0);
            this.Controls.Add(this.label_byte1);
            this.Controls.Add(this.textBox_byte15);
            this.Controls.Add(this.textBox_byte7);
            this.Controls.Add(this.textBox_byte14);
            this.Controls.Add(this.textBox_byte3);
            this.Controls.Add(this.textBox_byte13);
            this.Controls.Add(this.textBox_byte5);
            this.Controls.Add(this.textBox_byte12);
            this.Controls.Add(this.textBox_byte1);
            this.Controls.Add(this.button_heartRate);
            this.Controls.Add(this.label_samplingRate);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_customMessage);
            this.Controls.Add(this.label_COMPort);
            this.Controls.Add(this.label_helpSamplingCoefficient);
            this.Controls.Add(this.label_helpSamplingRate);
            this.Controls.Add(this.label_filterCoefficient);
            this.Controls.Add(this.label_COMMAND_BYTE_INDEX);
            this.Controls.Add(this.textBox_filterCoefficient);
            this.Controls.Add(this.textBox_samplingRate);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.button_alarmHex);
            this.Controls.Add(this.button_alarmBin);
            this.Controls.Add(this.button_applyFilterCoefficient);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_applySampleRate);
            this.Controls.Add(this.textBox_byte11);
            this.Controls.Add(this.textBox_byte6);
            this.Controls.Add(this.textBox_byte10);
            this.Controls.Add(this.textBox_byte2);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_byte9);
            this.Controls.Add(this.textBox_byte4);
            this.Controls.Add(this.textBox_byte8);
            this.Controls.Add(this.textBox_byte0);
            this.Controls.Add(this.joystickChart);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_COMPort);
            this.Name = "Form1";
            this.Text = "Joystick Calibrate App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_COMPort;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Timer timer_updateChart;
        private Joystick_2023_Control.Joystick_2023 joystickChart;
        private System.Windows.Forms.TextBox textBox_byte0;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialBT;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.TextBox textBox_samplingRate;
        private System.Windows.Forms.Label label_COMMAND_BYTE_INDEX;
        private System.Windows.Forms.Label label_COMPort;
        private System.Windows.Forms.Label label_customMessage;
        private System.Windows.Forms.Button button_applySampleRate;
        private System.Windows.Forms.Label label_helpSamplingRate;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_samplingRate;
        private System.Windows.Forms.Button button_heartRate;
        private System.Windows.Forms.TextBox textBox_byte1;
        private System.Windows.Forms.TextBox textBox_byte2;
        private System.Windows.Forms.TextBox textBox_byte3;
        private System.Windows.Forms.TextBox textBox_byte4;
        private System.Windows.Forms.TextBox textBox_byte6;
        private System.Windows.Forms.TextBox textBox_byte5;
        private System.Windows.Forms.TextBox textBox_byte7;
        private System.Windows.Forms.TextBox textBox_byte8;
        private System.Windows.Forms.TextBox textBox_byte9;
        private System.Windows.Forms.TextBox textBox_byte10;
        private System.Windows.Forms.TextBox textBox_byte11;
        private System.Windows.Forms.TextBox textBox_byte12;
        private System.Windows.Forms.TextBox textBox_byte13;
        private System.Windows.Forms.TextBox textBox_byte14;
        private System.Windows.Forms.TextBox textBox_byte15;
        private System.Windows.Forms.Label label_byte1;
        private System.Windows.Forms.Label label_byte2;
        private System.Windows.Forms.Label label_byte3;
        private System.Windows.Forms.Label label_byte4;
        private System.Windows.Forms.Label label_byte5;
        private System.Windows.Forms.Label label_byte6;
        private System.Windows.Forms.Label label_byte7;
        private System.Windows.Forms.Label label_byte8;
        private System.Windows.Forms.Label label_byte9;
        private System.Windows.Forms.Label label_byte10;
        private System.Windows.Forms.Label label_byte11;
        private System.Windows.Forms.Label label_byte12;
        private System.Windows.Forms.Label label_byte13;
        private System.Windows.Forms.Label label_byte14;
        private System.Windows.Forms.Label label_byte15;
        private System.Windows.Forms.Label label_byte0;
        private System.Windows.Forms.Label label_filterCoefficient;
        private System.Windows.Forms.Button button_applyFilterCoefficient;
        private System.Windows.Forms.TextBox textBox_filterCoefficient;
        private System.Windows.Forms.Label label_helpSamplingCoefficient;
        private System.Windows.Forms.Button button_LED;
        private System.Windows.Forms.TextBox textBox_alarmPatternBin;
        private System.Windows.Forms.TextBox textBox_alarmPatternHex;
        private System.Windows.Forms.Button button_alarmBin;
        private System.Windows.Forms.Button button_alarmHex;
        private System.Windows.Forms.ComboBox comboBox_alarmCountBin;
        private System.Windows.Forms.ComboBox comboBox_alarmCountHex;
        private System.Windows.Forms.Label label_XOut;
        private System.Windows.Forms.Label label_YOut;
        private System.Windows.Forms.Label label_ZOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_autoDetectCOMPort;
    }
}

