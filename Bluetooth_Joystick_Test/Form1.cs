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
using System.Threading;
using Microsoft.Win32;

namespace Bluetooth_Joystick_Test
{
    public partial class Form1 : Form
    {
        //UART_Decode_0x1A formSerialPort = new UART_Decode_0x1A();
        static class Constants
        {
            public const int REPORT_PACKET_COUNT = 8;
            public const int RX_BYTE_COUNT_NORMAL = 8;
            public const int RX_BYTE_COUNT_DAQ = 512;
            public const int RX_BYTE_COUNT_LOG = 8192;
            public const int BYTES_PER_FRAME = 4;
            public const double pi = 3.1416;
        }

        private byte[] msgRX;
        private byte[] msgTX;
        private const int BYTE_ARRAY_SIZE = 16;
        //private const int COMMAND_MODE_SERIAL = 1;
        //private const int COMMAND_MODE_PACKET = 2;
        private const int COMMAND_BYTE_INDEX = 8;
        private const int COMMAND_PACKET_SIZE = BYTE_ARRAY_SIZE;

        private const int CMD_START_ACTION_MODE = 0xA0;
        private const int CMD_TRANSMIT_RATE = 0xC0;
        private const int CMD_ALPHA = 0xC1;
        private const int CMD_ALARM = 0xC2;
        private const int CMD_LED = 0xC3;

        private byte[] commandPacket = new byte[COMMAND_PACKET_SIZE];

        private byte[] receivedBytes_Raw;
        //private byte[] receivedBytes;
        //private readonly string ACTION_MODE = "Decode 0x1A";
        //private readonly string ACTION_MODE = "Decode 0x1A";
        private readonly string ACTION_MODE = "Normal Mode";
        private int SamplingRate_10ms;
        private int joystick_X_Output;
        private int joystick_Y_Output;
        private int joystick_Z_Output;

        private int joystick_X_Input;
        private int joystick_Y_Input;
        private int joystick_Z_Input;
        private string serial_Mode = "Normal";

        private byte[] detection_DeviceSentBytes;

        private bool detection_Sequence_Found = false;
        private bool dataReceivedInSerialPort = false;




        // delegate is used to write to a UI control from a non-UI thread //ASMohsen
        private delegate void SetTextDeleg(byte[] dataBytes);

        public Form1()
        {
            InitializeComponent();
            //InitializeSerialCommunication();
        }

        private void ReadReceivedData(byte[] receivedBytes_Raw) //ASMohsen
        {

            switch (serial_Mode)
            {
                case "Detection":
                    dataReceivedInSerialPort = true;
                    detection_Sequence_Found = true;
                    for (int i = 0; i < receivedBytes_Raw.Length; i++)
                    {
                        if (receivedBytes_Raw[i] != detection_DeviceSentBytes[i])
                        {
                            detection_Sequence_Found = false;
                        }
                    }
                    break;

                case "Normal":
                    //receivedBytes = Decode_0x1A(receivedBytes_Raw);
                    //ShowReceivedData(receivedBytes_Raw);
                    if (ACTION_MODE == "Decode 0x1A")
                        Process_Received_Data(Decode_0x1A(receivedBytes_Raw));
                    else if (ACTION_MODE == "Normal Mode")
                        Process_Received_Data(receivedBytes_Raw);

                    break;
            }
        }
        private bool heartRate = false;

        private void Process_Received_Data(byte[] rxByte)
        {
            if (heartRate)
                button_heartRate.ForeColor = Color.Red;
            else button_heartRate.ForeColor = Color.Blue;
            heartRate = !heartRate;
            if (rxByte[COMMAND_BYTE_INDEX] == CMD_START_ACTION_MODE)
            {
                joystick_X_Input = rxByte[3];
                joystick_X_Input |= rxByte[2] << 8;
                label_X.Text = joystick_X_Input.ToString();
                joystick_Y_Input = rxByte[5];
                joystick_Y_Input |= rxByte[4] << 8;
                label_Y.Text = joystick_Y_Input.ToString();
                joystick_Z_Input = rxByte[7];
                joystick_Z_Input |= rxByte[6] << 8;
                label_Z.Text = joystick_Z_Input.ToString();
                label_XOut.Text = joystick_X_Output.ToString();
                label_YOut.Text = joystick_Y_Output.ToString();
                label_ZOut.Text = joystick_Z_Output.ToString();
                label_batteryLevel.Text = ((((rxByte[14] << 8) | rxByte[15])*3.3)/4096).ToString();
                joystickChart.Button = (rxByte[1] & 1) == 1;
                checkBox1.Checked = joystickChart.Button;
                joystickChart.X_Input = joystick_X_Input - 2048;
                joystickChart.Y_Input = joystick_Y_Input - 2048;
                joystickChart.Z_Input = joystick_Z_Input - 2048;
                for (int i = 0;i<16;i++)
                {

                }

                //for (int i = 0; i < serialBT.ReceivedBytesThreshold; i++)
                //{
                //    if (rxBytes[i] == 0x1A)
                //    {
                //        MessageBox.Show("got 26 in byte: " + i);
                //    }
                //}
            }
            //else if (rxByte[COMMAND_BYTE_INDEX]== )
            else
                checkBox1.Checked = !checkBox1.Checked;
            label_samplingRate.Text = joystickChart.SamplingRateMS.ToString();
            //else if (rxBytes[0] == 0)
        }
        //private void ShowReceivedData(byte[] bytesToShow)
        //{
        //    byte[] decodedBytes = new byte[bytesToShow.Length];
        //    //decodedBytes = Decode_0x1A(bytesToShow);
        //    string s = "";
        //    //int[] realData = new int[decodedBytes.Length];
        //    //int j = 0;

        //    //for(int i = 0; i < decodedBytes.Length;i++)
        //    //{
        //    //    if(i % 8 ==0 || i % 8 == 7)
        //    //    {

        //    //    }
        //    //    else
        //    //    {
        //    //        realData[j] = decodedBytes[i] * 256 + decodedBytes[i + 1];
        //    //        i++;
        //    //        j++;
        //    //    }
        //    //}
        //}
        private byte[] Decode_0x1A(byte[] codedBytes) //ASMohsen
        {
            byte[] decodedBytes = new byte[codedBytes.Length];

            // Copy entire array into decodedBytes
            for (int i = 0; i < codedBytes.Length; i++)
            {
                decodedBytes[i] = codedBytes[i];
            }

            if (codedBytes.Length == 8)
            {
                byte codeByte = decodedBytes[0]; // read Code Byte for byte0 - 6			
                byte code_Nibble = (byte)(0xF0 & codeByte); // codeByte: abc0 defg  code_Nibble:abc0 0000
                code_Nibble = (byte)(code_Nibble >> 1);     // codeByte: abc0 defg  code_Nibble:0abc 0000

                codeByte = (byte)(code_Nibble | (0x0F & codeByte)); //codeByte =  0abc 0000 | 0000 defg = 0abcdefg

                // check  Code Byte for channel 0 - 6
                for (int index = 0; index < 7; index++)
                {
                    if (((codeByte >> index) & 0x01) == 1)
                    { // Replace byte with 0x1A 
                        decodedBytes[index + 1] = 0x1A;
                    }
                }
            }

            if (codedBytes.Length == 16)
            {
                for (int dataPack = 0; dataPack < 2; dataPack++) // there are 8*2 = 16 data bytes is each sector
                {
                    byte codeByte = decodedBytes[dataPack * 8]; // read Code Byte for byte0 - 6			
                    byte code_Nibble = (byte)(0xF0 & codeByte); // codeByte: abc0 defg  code_Nibble:abc0 0000
                    code_Nibble = (byte)(code_Nibble >> 1);     // codeByte: abc0 defg  code_Nibble:0abc 0000

                    codeByte = (byte)(code_Nibble | (0x0F & codeByte)); //codeByte =  0abc 0000 | 0000 defg = 0abcdefg

                    // check  Code Byte for channel 0 - 6
                    for (int index = 0; index < 7; index++)
                    {
                        if (((codeByte >> index) & 0x01) == 1)
                        { // Replace byte with 0x1A
                            decodedBytes[8 * dataPack + index + 1] = 0x1A;
                        }

                    }
                }
            }


            if (codedBytes.Length == 512)
            {
                // Decode decodedBytes
                for (int dataPack = 0; dataPack < 64; dataPack++) // there are 32*16 = 512 data bytes is each sector
                {
                    byte codeByte = decodedBytes[dataPack * 8]; // read Code Byte for byte0 - 6			
                    byte code_Nibble = (byte)(0xF0 & codeByte); // codeByte: abc0 defg  code_Nibble:abc0 0000
                    code_Nibble = (byte)(code_Nibble >> 1);     // codeByte: abc0 defg  code_Nibble:0abc 0000

                    codeByte = (byte)(code_Nibble | (0x0F & codeByte)); //codeByte =  0abc 0000 | 0000 defg = 0abcdefg

                    // check  Code Byte for channel 0 - 6
                    for (int index = 0; index < 7; index++)
                    {
                        if (((codeByte >> index) & 0x01) == 1)
                        { // Replace byte with 0x1A
                            decodedBytes[8 * dataPack + index + 1] = 0x1A;
                        }

                    }
                }
            }

            return decodedBytes;
        }

        private void InitializeSerialCommunication()
        {
            //formSerialPort.SendCommandInterval = 50; // msec
            //formSerialPort.Detection_PCSentBytes =     new byte[8] { 0x00, 0xAA, 0x55, 0x00, 0x00, 0x00, 0x00, 0xFF };
            //formSerialPort.Detection_DeviceSentBytes = new byte[8] { 0x00, 0xAA, 0x55, 0x00, 0x00, 0x00, 0x00, 0xFF };

        }

        private void FormSerialPort_Received_Data_Ready(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormSerialPort_Log_Data_Ready(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormSerialPort_CommunicationStatus_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void timer_updateChart_Tick(object sender, EventArgs e)
        {
            //if (serialBT.IsOpen)
            //{
            //    for (int i = 0; i < BYTE_ARRAY_SIZE; i++)
            //    {
            //        msgRX[i] = (byte)(serialBT.ReadByte());
            //    }

            //}
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            
            //bool isPortCorrect = true;
            //byte[] autoDetectionPacket = new byte[8] { 0x00, 0xAA, 0x55, 0x00, 0x00, 0x00, 0x00, 0xFF };
            //byte[] rxBytes = new byte[8];
            //foreach (string port in SerialPort.GetPortNames())
            //{
            //    serialBT.Close();
            //    textBox_COMPort.Text = port;
            //    serialBT.PortName = port;
            //    try
            //    {
            //        serialBT.ReadTimeout = 10000;
            //        serialBT.WriteTimeout = 10000;
            //        serialBT.Open();
            //    }
            //    catch (System.Exception)
            //    {
            //        continue;
            //    }
            //    if (serialBT.IsOpen)
            //    {
            //        try
            //        {
            //            serialBT.Write(autoDetectionPacket, 0, autoDetectionPacket.Length);
            //        }
            //        catch (System.Exception)
            //        { }
            //        Thread.Sleep(5);
            //        try
            //        {
            //            serialBT.Read(rxBytes, 0, rxBytes.Length);
            //        }
            //        catch (System.Exception)
            //        { }
            //    }
            //    for (int i = 0; i < 8; i++)
            //    {
            //        if (rxBytes[i] != autoDetectionPacket[i])
            //        {
            //            isPortCorrect = false;
            //            break;
            //        }
            //        else
            //            continue;
            //    }
            //    if (isPortCorrect)
            //    {
            //        textBox_COMPort.Text = port;
            //        break;
            //    }
            //}
            if (!(serialBT.IsOpen))
            {
                if (checkBox_autoDetect.Checked == true)
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\SERIALCOMM");
                    object portReg;
                    if (key != null)
                    {
                        portReg = key.GetValue("\\Device\\BthModem0");
                        serialBT.PortName = portReg.ToString();
                        textBox_COMPort.Text = portReg.ToString();
                    }
                }
                else
                { serialBT.PortName = textBox_COMPort.Text; }

                try
                {
 
                    serialBT.Open();
                    commandPacket[COMMAND_BYTE_INDEX] = CMD_TRANSMIT_RATE;
                    commandPacket[COMMAND_BYTE_INDEX + 1] = (byte)int.Parse(textBox_samplingRate.Text);
                    serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);

                    commandPacket[COMMAND_BYTE_INDEX] = CMD_ALPHA;
                    commandPacket[COMMAND_BYTE_INDEX + 1] = (byte)int.Parse(textBox_filterCoefficient.Text);
                    serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);

                    SamplingRate_10ms = int.Parse(textBox_samplingRate.Text);
                    Thread.Sleep(SamplingRate_10ms * 10);
                    commandPacket[COMMAND_BYTE_INDEX] = (byte)CMD_START_ACTION_MODE;
                    serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);

                    joystickChart.SamplingRateMS = SamplingRate_10ms * 10;
                    timer_updateChart.Start();
                    button_connect.Text = "Disconnect";
                    button_connect.BackColor = Color.Green;
                    return;
            }
                catch (System.Exception)
            {
                MessageBox.Show("Retry");
            }


        }
            else
            {
                serialBT.Close();
                button_connect.Text = "Connect";
                button_connect.BackColor = Color.Orange;
                timer_updateChart.Stop();
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (serialBT.IsOpen)
            {
                byte[] comm = new byte[COMMAND_PACKET_SIZE];

                comm[0] = (byte)0;
                comm[1] = (byte)int.Parse(textBox_byte1.Text);
                comm[2] = (byte)int.Parse(textBox_byte2.Text);
                comm[3] = (byte)int.Parse(textBox_byte3.Text);
                comm[4] = (byte)int.Parse(textBox_byte4.Text);
                comm[5] = (byte)int.Parse(textBox_byte5.Text);
                comm[6] = (byte)int.Parse(textBox_byte6.Text);
                comm[7] = (byte)int.Parse(textBox_byte7.Text);
                comm[8] = (byte)int.Parse(textBox_byte8.Text);
                comm[9] = (byte)int.Parse(textBox_byte9.Text);
                comm[10] = (byte)int.Parse(textBox_byte10.Text);
                comm[11] = (byte)int.Parse(textBox_byte11.Text);
                comm[12] = (byte)int.Parse(textBox_byte12.Text);
                comm[13] = (byte)int.Parse(textBox_byte13.Text);
                comm[14] = (byte)int.Parse(textBox_byte14.Text);
                comm[15] = (byte)int.Parse(textBox_byte15.Text);
                //comm = Decode_0x1A(comm);

                serialBT.Write(comm, 0, comm.Length);

                textBox_byte0.Text = "Reserved";
                textBox_byte1.Text = "0";
                textBox_byte2.Text = "0";
                textBox_byte3.Text = "0";
                textBox_byte4.Text = "0";
                textBox_byte5.Text = "0";
                textBox_byte6.Text = "0";
                textBox_byte7.Text = "0";
                textBox_byte8.Text = "0";
                textBox_byte9.Text = "0";
                textBox_byte10.Text = "0";
                textBox_byte11.Text = "0";
                textBox_byte12.Text = "0";
                textBox_byte13.Text = "0";
                textBox_byte14.Text = "0";
                textBox_byte15.Text = "0";
            }
            else MessageBox.Show("Not connected");
        }
        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (serialBT.IsOpen)
            {
                if (sender.Equals(button_applySampleRate))
                {
                    commandPacket[COMMAND_BYTE_INDEX] = CMD_TRANSMIT_RATE;
                    commandPacket[COMMAND_BYTE_INDEX + 1] = (byte)int.Parse(textBox_samplingRate.Text);
                    serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);

                    SamplingRate_10ms = int.Parse(textBox_samplingRate.Text);
                    joystickChart.SamplingRateMS = SamplingRate_10ms * 10;
                }
                else if (sender.Equals(button_applyFilterCoefficient))
                {
                    int aplha = int.Parse(textBox_filterCoefficient.Text);

                    if (aplha < 100 && aplha > 0)
                    {
                        if (aplha == 100)
                            MessageBox.Show("no filtering will be applied");
                        commandPacket[COMMAND_BYTE_INDEX] = CMD_ALPHA;
                        commandPacket[COMMAND_BYTE_INDEX + 1] = (byte)aplha;
                        serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);
                    }
                    else
                        MessageBox.Show("Invalid filter coefficient");

                }
                else if (sender.Equals(button_alarmBin))
                {
                    commandPacket[COMMAND_BYTE_INDEX] = CMD_ALARM;
                    commandPacket[COMMAND_BYTE_INDEX + 1] = (byte)Convert.ToInt32(textBox_alarmPatternBin.Text, 2);
                    commandPacket[COMMAND_BYTE_INDEX + 2] = (byte)(Convert.ToInt32(textBox_alarmPatternBin.Text, 2) >> 8);
                    commandPacket[COMMAND_BYTE_INDEX + 3] = (byte)(Convert.ToInt32(textBox_alarmPatternBin.Text, 2) >> 16);
                    commandPacket[COMMAND_BYTE_INDEX + 4] = (byte)(Convert.ToInt32(textBox_alarmPatternBin.Text, 2) >> 24);
                    commandPacket[COMMAND_BYTE_INDEX + 5] = (byte)int.Parse(comboBox_alarmCountBin.Text);

                    serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);
                }
                else if (sender.Equals(button_alarmHex))
                {
                    commandPacket[COMMAND_BYTE_INDEX] = CMD_ALARM;
                    commandPacket[COMMAND_BYTE_INDEX + 1] = (byte)Convert.ToInt32(textBox_alarmPatternHex.Text, 16);
                    commandPacket[COMMAND_BYTE_INDEX + 2] = (byte)(Convert.ToInt32(textBox_alarmPatternHex.Text, 16) >> 8);
                    commandPacket[COMMAND_BYTE_INDEX + 3] = (byte)(Convert.ToInt32(textBox_alarmPatternHex.Text, 16) >> 16);
                    commandPacket[COMMAND_BYTE_INDEX + 4] = (byte)(Convert.ToInt32(textBox_alarmPatternHex.Text, 16) >> 24);
                    commandPacket[COMMAND_BYTE_INDEX + 5] = (byte)int.Parse(comboBox_alarmCountHex.Text);

                    serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);
                }


            }
            else MessageBox.Show("Not connected");
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(20);
            receivedBytes_Raw = new byte[serialBT.ReceivedBytesThreshold];
            if (serialBT.IsOpen == true && serialBT.BytesToRead > 0) // Note When Receiveing multiple of 64 bytes from STM32F7, a Zero Length Packet should be sent after sending the data into USB interface
            {// This will generate an interrupt in C# while there is no bytes received by the serial port!, so it is necessary to check if the BytesToRead property is non-zero
                serialBT.Read(receivedBytes_Raw, 0, receivedBytes_Raw.Length);
                // Invokes the delegate on the UI thread, and sends the receivedBytes that was received to the invoked method. 
                // ---- The "ShowReceivedData" method will be executed on the UI thread which allows populating of the textbox. 
                this.BeginInvoke(new SetTextDeleg(ReadReceivedData), new object[] { receivedBytes_Raw });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool led1State = true;
        private bool led2State = true;
        private bool led3State = true;
        private void button_LED_Click(object sender, EventArgs e)
        {
            
            if (serialBT.IsOpen)
            {

                commandPacket[COMMAND_BYTE_INDEX] = CMD_LED;
                if(sender == button_LED1)
                {
                    if (led1State)
                    {
                        commandPacket[COMMAND_BYTE_INDEX + 1] |= 1;
                        button_LED1.BackColor = Color.Green;

                    }
                    else
                    {
                        commandPacket[COMMAND_BYTE_INDEX + 1] &= 0xFE;
                        button_LED1.BackColor = SystemColors.Control;
                    }
                    led1State = !led1State;

                }
                else if (sender == button_LED2)
                {
                    if (led2State)
                    {
                        commandPacket[COMMAND_BYTE_INDEX + 1] |= (1<<1);
                        button_LED2.BackColor = Color.Green;

                    }
                    else
                    {
                        commandPacket[COMMAND_BYTE_INDEX + 1] &= 0xFD;
                        button_LED2.BackColor = SystemColors.Control;
                    }
                    led2State = !led2State;

                }
                else if (sender == button_LED3)
                {
                    if (led2State)
                    {
                        commandPacket[COMMAND_BYTE_INDEX + 1] |= (1 << 2);
                        button_LED3.BackColor = Color.Green;

                    }
                    else
                    {
                        commandPacket[COMMAND_BYTE_INDEX + 1] &= 0xFB;
                        button_LED3.BackColor = SystemColors.Control;
                    }
                    led3State = !led3State;

                }

                serialBT.Write(commandPacket, 0, COMMAND_PACKET_SIZE);

            }
        }


    }
}
