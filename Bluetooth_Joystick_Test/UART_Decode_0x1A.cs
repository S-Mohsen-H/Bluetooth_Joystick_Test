using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Bluetooth_Joystick_Test
{
    public partial class UART_Decode_0x1A : Form
    {

       // MessageBoxForm messageBox = new MessageBoxForm();

        //int receivedDataPackNo = 0;
        long logBytesIndex = 0;
        byte[] receivedLogBytes = new byte[15000000];
        byte[] receivedBytes;
        byte[,] logReceivedBytes = new byte[30000, 512];
        byte[] receivedBytes_Raw;
        //byte[] receivedBytesPool;
        byte[] sentBytes;
        byte[] detection_PCSentBytes;
        byte[] detection_DeviceSentBytes;
        char[] separator = { ',' };
        int blockNo = 0;
        //Color ledColor;
        
              
       
        string[] portNames;
        int portIndex = 0;
        bool dataReceivedInSerialPort;

        StopBits stopBits = StopBits.One;
        Parity parity = Parity.None;
        int baudRate = 9600;
        int dataBits = 8;
        bool sendBufferIsEmpty = true;
        int sendCommandInterval = 1000;
        bool portIsOpen;
        string serial_Mode = "";
        bool detection_Sequence_Found = false;
        int rx_Byte_Count_Normal;
        int rx_Byte_Count_DAQ;
        int rx_Byte_Count_LOG;
        int maxBlockCount = 0;

        int tick = 0;

        public class MessageEventArgs : EventArgs
        {
            public string Message;
        }

        // delegate is used to write to a UI control from a non-UI thread //ASMohsen
        private delegate void SetTextDeleg(byte[] dataBytes);

        public event EventHandler Received_Data_Ready;
        public event EventHandler Log_Data_Ready;
        public event EventHandler CommunicationStatus_Changed;
        public event EventHandler ProgressChanghed;
        //public event EventHandler New_Message_Received;
        
        

        // Properties

        public bool PortIsOpen
        {
            get
            {
                return portIsOpen;
            }          
        }

        public StopBits SerialPortStopBits
        {
            get
            {
                return stopBits;
            }
            set
            {
                stopBits = value;
            }
        }

        public Parity SerialPortParity
        {
            get
            {
                return parity;
            }
            set
            {
                parity = value;
            }
        }

        public int SerialPortBaudRate
        {
            get
            {
                return baudRate;
            }
            set
            {
                baudRate = value;
            }
        }

        public int SerialPortDataBits
        {
            get
            {
                return dataBits;
            }
            set
            {
                dataBits = value;
            }
        }
  
        public byte[] ReceivedBytes
        {
            get
            {
                return receivedBytes;
            }
        }

        public byte[,] LogReceivedBytes
        {
            get
            {
                return logReceivedBytes;
            }
        }

        public byte[] SentBytes
        {
            set
            {
                sentBytes = value;
                AddCommand(sentBytes);
            }
            get
            {
                return sentBytes;
            }
        }

        public byte[] Detection_PCSentBytes
        {
            set
            {
                detection_PCSentBytes = value;              
            }
        }

        public byte[] Detection_DeviceSentBytes
        {
            set
            {
                detection_DeviceSentBytes = value;              
            }
        }
       
        public int SendCommandInterval
        {
            get
            {
                return sendCommandInterval;
            }
            set
            {
                sendCommandInterval = value;
                timerSendCommand.Interval = sendCommandInterval;
            }
        }

        public string Serial_Mode
        {
            get
            {
                return serial_Mode;
            }
            set
            {               
                serial_Mode = value;                
                switch (serial_Mode)
                {                    
                    case "Detection":
                        serialPort.ReceivedBytesThreshold = detection_DeviceSentBytes.Length;
                        break;
                    case "Normal":
                        serialPort.ReceivedBytesThreshold = rx_Byte_Count_Normal;
                        break;
                    case "DAQ":
                        serialPort.ReceivedBytesThreshold = rx_Byte_Count_DAQ;
                        break;
                    case "LOG":
                        serialPort.ReceivedBytesThreshold = rx_Byte_Count_LOG;
                        break;
                }                
            }
        }

        public int RX_Byte_Count_Normal
        {
            get
            {
                return rx_Byte_Count_Normal;
            }
            set
            {
                rx_Byte_Count_Normal = value;
                if (serialPort != null)
                {
                    serialPort.ReceivedBytesThreshold = rx_Byte_Count_Normal;
                }
            }
        }

        public int RX_Byte_Count_DAQ
        {
            get
            {
                return rx_Byte_Count_DAQ;
            }
            set
            {
                rx_Byte_Count_DAQ = value;

            }
        }

        public int RX_Byte_Count_LOG
        {
            get
            {
                return rx_Byte_Count_LOG;
            }
            set
            {
                rx_Byte_Count_LOG = value;

            }
        }

        public int MaxBlockCount
        {
            get
            {
                return maxBlockCount;
            }
            set
            {
                maxBlockCount = value;
                blockNo = 0;
                logBytesIndex = 0;
            }
        }   

        

        public UART_Decode_0x1A()
        {
            InitializeComponent();
        }
                
        private void DetectSerialPort()
        {
            // 
            // serialPort
            // 
            serial_Mode = "Detection";
            if (serialPort != null)
            {
                serialPort.Dispose();
            }
            serialPort = new System.IO.Ports.SerialPort(/*this.components*/);
            serialPort.ReceivedBytesThreshold = detection_DeviceSentBytes.Length;
            serialPort.BaudRate = baudRate;
            serialPort.DataBits = dataBits;
            serialPort.Parity = parity;
            serialPort.StopBits = stopBits;
            serialPort.ReadBufferSize = 8192;
            serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);

            //if (serialPort.IsOpen)
            //{
            //    serialPort.Close();
            //}
            portNames = SerialPort.GetPortNames();
            string s = "";
            for (int i = 0; i < portNames.Length; i++)
            {
                s += portNames[i] + ", ";
            }
            labelCOMStatus.Text = "Detected COM ports: " + s;
            portIndex = 0;
            dataReceivedInSerialPort = false;
            if (portNames.Length != 0)
            {
                timerAutoDetectPort.Start();
            }
            else
            {
                buttonStatus.Enabled = true;
                buttonStatus.Text = "Try Again";
                labelCOMStatus.Text = "No serial port is detected on this machin";
                buttonStatus.BackColor = Color.Red;
            }           
        }

        private string ConvertToHexFormat(int n)
        {
            string s;
            s = Convert.ToString(n, 16);
            if (s.Length < 2)
            {
                s = "0" + s;
            }
            s = "0x" + s.ToUpper();
            return s;
        }

        private void FormCommunicationPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }

        private byte[] Decode_To_Bytes(byte[] inData)
        {
            byte[] outData = new byte[inData.Length / 2];

            for (int i = 0; i < outData.Length; i++)
            {
                outData[i] = (byte)(inData[2 * i] + inData[2 * i + 1]);
            }
            return outData;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) //ASMohsen
        {            
            Thread.Sleep(20);            
            receivedBytes_Raw = new byte[serialPort.ReceivedBytesThreshold];
            if (serialPort.IsOpen == true && serialPort.BytesToRead > 0) // Note When Receiveing multiple of 64 bytes from STM32F7, a Zero Length Packet should be sent after sending the data into USB interface
            {// This will generate an interrupt in C# while there is no bytes received by the serial port!, so it is necessary to check if the BytesToRead property is non-zero
                serialPort.Read(receivedBytes_Raw, 0, receivedBytes_Raw.Length);
                // Invokes the delegate on the UI thread, and sends the receivedBytes that was received to the invoked method. 
                // ---- The "ShowReceivedData" method will be executed on the UI thread which allows populating of the textbox. 
                this.BeginInvoke(new SetTextDeleg(ReadReceivedData), new object[] { receivedBytes_Raw });
            }
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
                    receivedBytes = Decode_0x1A(receivedBytes_Raw);
                    ShowReceivedData(receivedBytes_Raw);
                    Received_Data_Ready(null, null);
                    break;
            }

        }

        private void KeepRxBytes( byte[] LogBytes)
        {
            for (int i = 0; i < LogBytes.Length; i++)
            {
                receivedLogBytes[logBytesIndex] = LogBytes[i];
                logBytesIndex++;
            }
        }

        private void UpdateLED()
        {
            if (buttonStatus.BackColor == Color.Blue)
            {
                buttonStatus.BackColor = Color.LightGray;
            }
            else
            {
                buttonStatus.BackColor = Color.Blue;
            }
        }

        private void ShowReceivedData(byte[] bytesToShow)
        {
            byte[] decodedBytes = new byte[bytesToShow.Length];
            //decodedBytes = Decode_0x1A(bytesToShow);
            string s = "";
            //int[] realData = new int[decodedBytes.Length];
            //int j = 0;

            //for(int i = 0; i < decodedBytes.Length;i++)
            //{
            //    if(i % 8 ==0 || i % 8 == 7)
            //    {

            //    }
            //    else
            //    {
            //        realData[j] = decodedBytes[i] * 256 + decodedBytes[i + 1];
            //        i++;
            //        j++;
            //    }
            //}
        }

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

        private void ShwoDAQData(byte[] bytesToShow)
        {
            string s = "";
            for (int i = 0; i < bytesToShow.Length; i++)
            {
                if (i % 8 == 0)
                {
                    s += i.ToString() + "\t";
                }

                   s += ConvertToHexFormat(bytesToShow[i]) + "   " + "( " + bytesToShow[i].ToString() + " )" + "\t";
                             

                if (i % 8 == 7)
                {
                    s += "\r\n";
                }
                progressBar1.Value = i * 100 / (bytesToShow.Length - 1);
            }
            textBoxReceivedData.Text = s;
        }

        private void timerAutoDetectPort_Tick(object sender, EventArgs e)
        {
            if ((serialPort !=null) && (serialPort.IsOpen == true))
            {
                if (detection_Sequence_Found == false)
                {
                    serialPort.Close();
                    if (portIndex < portNames.Length - 1)
                    {
                        portIndex++;
                        labelCOMStatus.Text = "Testing port " + portNames[portIndex];                        
                    }
                    else
                    {

                        buttonStatus.Enabled = true;
                        buttonStatus.Text = "Try Again";
                        if (dataReceivedInSerialPort == true)
                        {
                            labelCOMStatus.Text = "Invalid data Sequence detected! ";
                            buttonStatus.BackColor = Color.Red;
                            string dataString = "";
                            for (int i = 0; i < receivedBytes_Raw.Length; i++)
                            {
                                dataString += ConvertToHexFormat(receivedBytes_Raw [i]) + ",";
                                if ((i == detection_DeviceSentBytes.Length - 2) || i % 8 == 0)
                                {

                                    dataString += "\r\n";
                                }
                                else
                                {
                                    if (i % 2 == 0)
                                    {
                                        dataString += "\t";
                                    }
                                }
                            }
                            textBoxLastDataString.Text = dataString;

                        }
                        else
                        {
                            buttonStatus.Enabled = true;
                            buttonStatus.Text = "Try Again";
                            labelCOMStatus.Text = "Nothing received from available serial ports. ";
                            buttonStatus.BackColor = Color.Red;
                        }
                        timerAutoDetectPort.Stop();
                    }
                }
                else
                {
                    //Detection is successful
                    timerAutoDetectPort.Stop();
                    labelCOMStatus.Text = "Connecting to port " + serialPort.PortName;
                    buttonStatus.BackColor = Color.Blue;
                    timerSendCommand.Start();
                    serialPort.ReceivedBytesThreshold = rx_Byte_Count_Normal;      //Start normal serial port operation
                    serial_Mode = "Normal";
                    portIsOpen = true;

                   
                }
            }
            else
            {
                if (serialPort != null)
                {
                    serialPort.PortName = portNames[portIndex];
                    labelCOMStatus.Text = "Testing port " + portNames[portIndex];
                    try
                    {
                        serialPort.Open();
                        serialPort.Write(detection_PCSentBytes, 0, detection_PCSentBytes.Length);
                    }
                    catch
                    {
                        if (portIndex < portNames.Length - 1)
                        {
                            portIndex++;
                        }
                        else
                        {
                            buttonStatus.Enabled = true;
                            buttonStatus.BackColor = Color.White;
                            buttonStatus.Text = "Try Again";
                            labelCOMStatus.Text = "No valid device is detected. Please check your cable and try again after 5 seconds. ";
                            timerAutoDetectPort.Stop();
                        }
                    }
                }
            }
        }

        private byte[] Code_To_Nibbles(byte[] inBytes)
        {
            byte[] outBytes = new byte[2 * inBytes.Length];

            for (int i = 0; i < inBytes.Length; i++)
            {
                outBytes[2 * i] = (byte)(inBytes[i] & 0xF0);
                outBytes[2 * i + 1] = (byte)(inBytes[i] & 0x0F);
            }
            return outBytes;
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            FindSerialPort();
        }
        public void FindSerialPort()
        {            
            buttonStatus.Enabled = false;
            buttonStatus.Text = "";
            buttonStatus.BackColor = Color.Gray;
            DetectSerialPort();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        

        private void AddCommand(byte[] sentBytes)
        {
            sendBufferIsEmpty = false;
            string command_String="";
            for(int i=0; i<sentBytes.Length;i++)
            {
                command_String+= ConvertToHexFormat(sentBytes[i]) + ",";
            }
            
            int k = textBoxCommandQueue.Lines.Length;
            if ( k!= 0)
            {
                textBoxCommandQueue.AppendText("\r\n");
            }
            textBoxCommandQueue.AppendText((k + 1).ToString("00") + "-" + command_String);

            k = 0;
        }

        public void RemoveCommand()
        {
            string s = "";
            // Remove Line 1 and if it is not the "No Operation" command add it to the other Textbox             
            for (int i = 1; i < textBoxCommandQueue.Lines.Length; i++)
            {
                string line = textBoxCommandQueue.Lines[i];

                s += i.ToString("00") + "-" + line.Remove(0, 3);
                if (i < textBoxCommandQueue.Lines.Length - 1)
                {
                    s += "\r\n";
                }
            }           
            textBoxCommandQueue.Text = s;
            if (s.Length == 0)
            {
                sendBufferIsEmpty = true;
            }
            else
            {
                sendBufferIsEmpty = false;
            }

        }

        private void timerSendCommand_Tick(object sender, EventArgs e)
        {
            if (sendBufferIsEmpty == false)
            {
                // Send the first line of TextBoxQueue
                String s= textBoxCommandQueue.Lines[0].Remove(0,3);
                String[] commandStrings = s.Split(separator);
                byte[] commandBytes = new byte[sentBytes.Length]; 
                for (int i = 0; i < sentBytes.Length; i++)
                {
                    commandBytes[i] = Convert.ToByte(commandStrings[i],16);
                }

                try
                {
                    serialPort.Write(commandBytes, 0, commandBytes.Length);
                }
                catch
                {
                        //messageBox.button_No.Hide();
                        //messageBox.button_Yes.Hide();
                        //messageBox.button_Ok.Show();
                        //messageBox.label_Caption.Text = "Connection to Well-Logger lost!";
                        //messageBox.label_Message.Text = "Please Save your data.";
                        //int captionLeft = messageBox.Width / 2 - messageBox.label_Caption.Width / 2;
                        //int msgLeft = messageBox.Width / 2 - messageBox.label_Message.Width / 2;
                        //messageBox.label_Caption.Location = new Point(captionLeft, 21);
                        //messageBox.label_Message.Location = new Point(msgLeft, 41);
                        //messageBox.StartPosition = FormStartPosition.CenterScreen;
                        //messageBox.Visible = true;
                }

                RemoveCommand();
            }
        }

        private void UART_Decode_0x1A_Load(object sender, EventArgs e)
        {
            InitializeSerialportDetection();
        }

        public void InitializeSerialportDetection()
        {
            DetectSerialPort();
            timerFindPort.Enabled = true;
        }

        private void buttonStatus_BackColorChanged(object sender, EventArgs e)
        {
            CommunicationStatus_Changed(null, null);
        }

        private void timerFindPort_Tick(object sender, EventArgs e)
        {
            if (buttonStatus.BackColor == Color.Red)
            {
                FindSerialPort();
                timerFindPort.Enabled = false;
            }

        }

        private void timer200msec_Tick(object sender, EventArgs e)
        {
            timer200msec.Enabled = false;
            byte[] buffer = new byte[512];
            int m = maxBlockCount * 16;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < 512; i++)
                {
                    buffer[i] = receivedLogBytes[i + j * 512];
                    receivedBytes = Decode_0x1A(buffer);
                }
                for (int n = 0; n < 512; n++)
                {
                    //logReceivedBytes[j, n] = new byte();
                    logReceivedBytes[j, n] = receivedBytes[n];
                }
            }
            Log_Data_Ready(null, null);
        }       

    }
}
