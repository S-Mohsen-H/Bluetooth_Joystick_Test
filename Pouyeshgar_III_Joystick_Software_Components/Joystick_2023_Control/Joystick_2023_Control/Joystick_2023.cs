using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Joystick_2023_Control
{
    public partial class Joystick_2023 : UserControl
    {
        public Joystick_2023()
        {
            InitializeComponent();
        }

        private double max_Minus;

        private double offset_Minus;

        private double offset_Plus;

        private double max_Plus;

        private double input;

        private double output;

        private bool x_Flag;

        private bool y_Flag;

        private bool z_Flag;

        private bool joystick_Flag;

        private double x_Input = 0.0;

        private double x_Output = 0.0;

        private double x_Offset_Plus = 0.0;

        private double x_Offset_Minus = 0.0;

        private double x_Max_Plus = 0.0;

        private double x_Max_Minus = 0.0;

        private double x_Slope_Plus = 0.0;

        private double x_Slope_Minus = 0.0;

        private double x_Dead_Band = 50.0;

        private double y_Input = 0.0;

        private double y_Output = 0.0;

        private double y_Offset_Plus = 0.0;

        private double y_Offset_Minus = 0.0;

        private double y_Max_Plus = 0.0;

        private double y_Max_Minus = 0.0;

        private double y_Slope_Plus = 0.0;

        private double y_Slope_Minus = 0.0;

        private double y_Dead_Band = 50.0;

        private double z_Input = 0.0;

        private double z_Output = 0.0;

        private double z_Offset_Plus = 0.0;

        private double z_Offset_Minus = 0.0;

        private double z_Max_Plus = 0.0;

        private double z_Max_Minus = 0.0;

        private double z_Slope_Plus = 0.0;

        private double z_Slope_Minus = 0.0;

        private double z_Dead_Band = 50.0;

        private string title_name;

        private byte joystick_Mode_Flag = 0;

        private bool button = false;

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        [Description("Rate of smapling ( Integer value between 1 and 1000 Hz )")]
        [Category("Sampling Rate")]
        public int SamplingRateMS
        {
            get
            {
                return timer_Update_Chart.Interval;
            }
            set
            {
                if (value > 1000 && value < 1)
                    MessageBox.Show("Invalid SamplingRateMS value");
                else
                    timer_Update_Chart.Interval = value;
            }
        }
        [Category("Button")]
        [Description("Button status")]
        public bool Button
        {
            get
            {
                return button;
            }
            set
            {
                button = value;
            }
        }
        [Category("X Axis")]
        [Description("Raw Output of Joystick X Axis (0 ... 4095)")]
        public double X_Input
        {
            get
            {
                return x_Input;
            }
            set
            {
                if (value >= -2048.0 && value < 2048.0)
                {
                    x_Input = value;
                }
                else
                {
                    MessageBox.Show("Out of Range!");
                }
            }
        }

        [Description("Output of Joystick X Axis (0 ... 1000)")]
        [Category("X Axis")]
        public double X_Output
        {
            get
            {
                return x_Output;
            }
            set
            {
                x_Output = value;
            }
        }

        [Description("Positive Deadband for X Axis (0 ... 4095)")]
        [Category("X Axis")]
        public double X_Offset_Plus
        {
            get
            {
                return x_Offset_Plus;
            }
            set
            {
                x_Offset_Plus = value;
            }
        }

        [Category("X Axis")]
        [Description("Negetive Deadband for X Axis (0 ... 4095)")]
        public double X_Offset_Minus
        {
            get
            {
                return x_Offset_Minus;
            }
            set
            {
                x_Offset_Minus = value;
            }
        }

        [Description("Max Plus for X Axis (0 ... 4095)")]
        [Category("X Axis")]
        public double X_Max_Plus
        {
            get
            {
                return x_Max_Plus;
            }
            set
            {
                x_Max_Plus = value;
            }
        }

        [Category("X Axis")]
        [Description("Max Minus for X Axis (0 ... 4095)")]
        public double X_Max_Minus
        {
            get
            {
                return x_Max_Minus;
            }
            set
            {
                x_Max_Minus = value;
            }
        }

        [Description("X Plus Slope")]
        [Category("X Axis")]
        public double X_Slope_Plus
        {
            get
            {
                return x_Slope_Plus;
            }
            set
            {
                x_Slope_Plus = value;
            }
        }

        [Description("X Minus Slope")]
        [Category("X Axis")]
        public double X_Slope_Minus
        {
            get
            {
                return x_Slope_Minus;
            }
            set
            {
                x_Slope_Minus = value;
            }
        }

        [Description("X Dead Band")]
        [Category("X Axis")]
        public double X_Dead_Band
        {
            get
            {
                return x_Dead_Band;
            }
            set
            {
                x_Dead_Band = value;
            }
        }

        [Category("Y Axis")]
        [Description("Raw Output of Joystick Y Axis (0 ... 4095)")]
        public double Y_Input
        {
            get
            {
                return y_Input;
            }
            set
            {
                y_Input = value;
            }
        }

        [Description("Output of Joystick Y Axis (0 ... 1000)")]
        [Category("Y Axis")]
        public double Y_Output
        {
            get
            {
                return y_Output;
            }
            set
            {
                y_Output = value;
            }
        }

        [Category("Y Axis")]
        [Description("Positive Deadband for Y Axis (0 ... 4095)")]
        public double Y_Offset_Plus
        {
            get
            {
                return y_Offset_Plus;
            }
            set
            {
                y_Offset_Plus = value;
            }
        }

        [Description("Negetive Deadband for Y Axis (0 ... 4095)")]
        [Category("Y Axis")]
        public double Y_Offset_Minus
        {
            get
            {
                return y_Offset_Minus;
            }
            set
            {
                y_Offset_Minus = value;
            }
        }

        [Description("Max Plus for Y Axis (0 ... 4095)")]
        [Category("Y Axis")]
        public double Y_Max_Plus
        {
            get
            {
                return y_Max_Plus;
            }
            set
            {
                y_Max_Plus = value;
            }
        }

        [Category("Y Axis")]
        [Description("Max Minus for Y Axis (0 ... 4095)")]
        public double Y_Max_Minus
        {
            get
            {
                return y_Max_Minus;
            }
            set
            {
                y_Max_Minus = value;
            }
        }

        [Description("Y Plus Slope")]
        [Category("Y Axis")]
        public double Y_Slope_Plus
        {
            get
            {
                return y_Slope_Plus;
            }
            set
            {
                y_Slope_Plus = value;
            }
        }

        [Description("Y Minus Slope")]
        [Category("Y Axis")]
        public double Y_Slope_Minus
        {
            get
            {
                return y_Slope_Minus;
            }
            set
            {
                y_Slope_Minus = value;
            }
        }

        [Description("Y Dead Band")]
        [Category("Y Axis")]
        public double Y_Dead_Band
        {
            get
            {
                return y_Dead_Band;
            }
            set
            {
                y_Dead_Band = value;
            }
        }

        [Description("Raw Output of Joystick Z Axis (0 ... 4095)")]
        [Category("Z Axis")]
        public double Z_Input
        {
            get
            {
                return z_Input;
            }
            set
            {
                z_Input = value;
            }
        }

        [Category("Z Axis")]
        [Description("Output of Joystick Z Axis (0 ... 1000)")]
        public double Z_Output
        {
            get
            {
                return z_Output;
            }
            set
            {
                z_Output = value;
            }
        }

        [Category("Z Axis")]
        [Description("Positive Deadband for Z Axis (0 ... 4095)")]
        public double Z_Offset_Plus
        {
            get
            {
                return z_Offset_Plus;
            }
            set
            {
                z_Offset_Plus = value;
            }
        }

        [Description("Negetive Deadband for Z Axis (0 ... 4095)")]
        [Category("Z Axis")]
        public double Z_Offset_Minus
        {
            get
            {
                return z_Offset_Minus;
            }
            set
            {
                z_Offset_Minus = value;
            }
        }

        [Description("Max Plus for Z Axis (0 ... 4095)")]
        [Category("Z Axis")]
        public double Z_Max_Plus
        {
            get
            {
                return z_Max_Plus;
            }
            set
            {
                z_Max_Plus = value;
            }
        }

        [Description("Max Minus for Z Axis (0 ... 4095)")]
        [Category("Z Axis")]
        public double Z_Max_Minus
        {
            get
            {
                return z_Max_Minus;
            }
            set
            {
                z_Max_Minus = value;
            }
        }

        [Category("Z Axis")]
        [Description("Z Plus Slope")]
        public double Z_Slope_Plus
        {
            get
            {
                return z_Slope_Plus;
            }
            set
            {
                z_Slope_Plus = value;
            }
        }

        [Category("Z Axis")]
        [Description("Z Minus Slope")]
        public double Z_Slope_Minus
        {
            get
            {
                return z_Slope_Minus;
            }
            set
            {
                z_Slope_Minus = value;
            }
        }

        [Category("Z Axis")]
        [Description("Z Dead Band")]
        public double Z_Dead_Band
        {
            get
            {
                return z_Dead_Band;
            }
            set
            {
                z_Dead_Band = value;
            }
        }

        [Description("Inter Name")]
        [Category("Title_Name")]
        public string Title_Name
        {
            get
            {
                return title_name;
            }
            set
            {
                title_name = value;
            }
        }

        [Description("Joystick Mode")]
        [Category("Joystick Mode Axis")]
        public byte Joystick_Mode_Flag
        {
            get
            {
                return joystick_Mode_Flag;
            }
            set
            {
                joystick_Mode_Flag = value;
            }
        }

        private void pictureBox_Set_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.LED2_Green_ON;
        }

        private void pictureBox_Set_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = Properties.Resources.LED2_Green_OFF;
        }

        private void pictureBox_Set_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (x_Flag)
            {
                switch (pictureBox.Name)
                {
                    case "pictureBox_Set_Max":
                        x_Max_Plus = x_Input;
                        max_Plus = x_Input;
                        x_Slope_Plus = 1000.0 / (x_Max_Plus - x_Offset_Plus);
                        break;
                    case "pictureBox_Set_Zero":
                        x_Offset_Plus = x_Input + x_Dead_Band / 2.0;
                        x_Offset_Minus = x_Input - x_Dead_Band / 2.0;
                        x_Slope_Plus = 1000.0 / (x_Max_Plus - x_Offset_Plus);
                        x_Slope_Minus = 1000.0 / (x_Offset_Minus - x_Max_Minus);
                        offset_Plus = x_Input + x_Dead_Band / 2.0;
                        offset_Minus = x_Input - x_Dead_Band / 2.0;
                        break;
                    case "pictureBox_Set_Min":
                        x_Max_Minus = x_Input;
                        max_Minus = x_Input;
                        x_Slope_Minus = 1000.0 / (x_Offset_Minus - x_Max_Minus);
                        break;
                }
            }

            if (y_Flag)
            {
                switch (pictureBox.Name)
                {
                    case "pictureBox_Set_Max":
                        y_Max_Plus = y_Input;
                        y_Slope_Plus = 1000.0 / (y_Max_Plus - y_Offset_Plus);
                        max_Plus = y_Input;
                        break;
                    case "pictureBox_Set_Zero":
                        y_Offset_Plus = y_Input + y_Dead_Band / 2.0;
                        y_Offset_Minus = y_Input - y_Dead_Band / 2.0;
                        y_Slope_Plus = 1000.0 / (y_Max_Plus - y_Offset_Plus);
                        y_Slope_Minus = 1000.0 / (y_Offset_Minus - y_Max_Minus);
                        offset_Plus = y_Input + y_Dead_Band / 2.0;
                        offset_Minus = y_Input - y_Dead_Band / 2.0;
                        break;
                    case "pictureBox_Set_Min":
                        y_Max_Minus = y_Input;
                        y_Slope_Minus = 1000.0 / (y_Offset_Minus - y_Max_Minus);
                        max_Minus = y_Input;
                        break;
                }
            }

            if (z_Flag)
            {
                switch (pictureBox.Name)
                {
                    case "pictureBox_Set_Max":
                        z_Max_Plus = z_Input;
                        z_Slope_Plus = 1000.0 / (z_Max_Plus - z_Offset_Plus);
                        max_Plus = z_Input;
                        break;
                    case "pictureBox_Set_Zero":
                        z_Offset_Plus = z_Input + z_Dead_Band / 2.0;
                        z_Offset_Minus = z_Input - z_Dead_Band / 2.0;
                        z_Slope_Plus = 1000.0 / (z_Max_Plus - z_Offset_Plus);
                        z_Slope_Minus = 1000.0 / (z_Offset_Minus - z_Max_Minus);
                        offset_Plus = z_Input + z_Dead_Band / 2.0;
                        offset_Minus = z_Input - z_Dead_Band / 2.0;
                        break;
                    case "pictureBox_Set_Min":
                        z_Max_Minus = z_Input;
                        z_Slope_Minus = 1000.0 / (z_Offset_Minus - z_Max_Minus);
                        max_Minus = z_Input;
                        break;
                }
            }
        }

        private void timer_Update_Chart_Tick(object sender, EventArgs e)
        {
            label_Title.Text = title_name + " Calibrator";
            if (!joystick_Flag)
            {
                chart_Transfer_Function.Series[0].Points.Clear();
                chart_Transfer_Function.Series[0].Points.AddXY(max_Minus, -1000.0);
                chart_Transfer_Function.Series[0].Points.AddXY(offset_Minus, 0.0);
                chart_Transfer_Function.Series[0].Points.AddXY(offset_Plus, 0.0);
                chart_Transfer_Function.Series[0].Points.AddXY(max_Plus, 1000.0);
            }
            else
            {
                int num = 950;
                if (z_Input > 2047.0)
                {
                    z_Input = 2047.0;
                }

                if (z_Input < -2048.0)
                {
                    z_Input = -2048.0;
                }

                float num2 = (float)(z_Output * 150.0 * 3.14 / 368640.0);
                double xValue = (double)num * Math.Sin(num2);
                double yValue = (double)num * Math.Cos(num2);
                chart_Transfer_Function.Series[0].Points.Clear();
                chart_Transfer_Function.Series[0].Points.AddXY(0.0, 0.0);
                chart_Transfer_Function.Series[0].Points.AddXY(xValue, yValue);
                chart_Transfer_Function.Series[1].Points.Clear();
                chart_Transfer_Function.Series[1].Points.AddXY(x_Output, y_Output);
            }

            if (x_Flag)
            {
                input = x_Input;
                output = x_Output;
            }

            if (y_Flag)
            {
                input = y_Input;
                output = y_Output;
            }

            if (z_Flag)
            {
                input = z_Input;
                output = z_Output;
            }

            Update_Level_Bar((float)input);
            Update_Output_Level_Bar((float)output);
            if (button)
            {
                pictureBox_button.Image = Properties.Resources.LED2_Green_ON;
            }
            else
            {
                pictureBox_button.Image = Properties.Resources.LED2_Green_OFF;
            }





            label_Minus.Text = x_Slope_Minus.ToString();
            label_Plus.Text = x_Slope_Plus.ToString();
        }

        private void Update_Level_Bar(float x)
        {
            Bitmap bitmap = new Bitmap(200, 5);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            SolidBrush brush = new SolidBrush(Color.FromArgb(32, 32, 32));
            Rectangle rect = new Rectangle(0, 0, 200, 5);
            Rectangle rect2 = new Rectangle(0, 0, 199, 4);
            Pen pen = new Pen(Color.FromArgb(64, 64, 64), 0.5f);
            float num = bitmap.Width;
            RectangleF rect3;
            if (0f <= x && x < 2048f)
            {
                float x2 = num / 2f;
                rect3 = new RectangleF(x2, 0f, num / 4094f * x, 5f);
            }
            else
            {
                float x2 = num / 4096f * x + num / 2f;
                rect3 = new RectangleF(x2, 0f, num / 2f - x2, 5f);
            }

            SolidBrush brush2 = new SolidBrush(Color.Gold);
            graphics.FillRectangle(brush, rect);
            graphics.FillRectangle(brush2, rect3);
            graphics.DrawRectangle(pen, rect2);
            Point[] array = new Point[2]
            {
                new Point(100, 0),
                new Point(100, 5)
            };
            Pen pen2 = new Pen(Color.Gold, 1f);
            if (x == 0f)
            {
                graphics.DrawLine(pen2, array[0], array[1]);
            }

            pictureBox1.Image = bitmap;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            x_Flag = false;
            y_Flag = false;
            z_Flag = false;
            joystick_Flag = false;
            label_X.ForeColor = Color.FromArgb(64, 64, 64);
            label_Y.ForeColor = Color.FromArgb(64, 64, 64);
            label_Z.ForeColor = Color.FromArgb(64, 64, 64);
            label_Joystick.ForeColor = Color.FromArgb(64, 64, 64);
            switch (label.Name)
            {
                case "label_X":
                    x_Flag = true;
                    label_X.ForeColor = Color.FromArgb(200, 200, 200);
                    break;
                case "label_Y":
                    y_Flag = true;
                    label_Y.ForeColor = Color.FromArgb(200, 200, 200);
                    break;
                case "label_Z":
                    z_Flag = true;
                    label_Z.ForeColor = Color.FromArgb(200, 200, 200);
                    break;
                case "label_Joystick":
                    joystick_Flag = true;
                    label_Joystick.ForeColor = Color.FromArgb(200, 200, 200);
                    break;
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            switch (label.Name)
            {
                case "label_X":
                    if (!x_Flag)
                    {
                        label_X.ForeColor = Color.FromArgb(100, 100, 100);
                    }

                    break;
                case "label_Y":
                    if (!y_Flag)
                    {
                        label_Y.ForeColor = Color.FromArgb(100, 100, 100);
                    }

                    break;
                case "label_Z":
                    if (!z_Flag)
                    {
                        label_Z.ForeColor = Color.FromArgb(100, 100, 100);
                    }

                    break;
                case "label_Joystick":
                    if (!joystick_Flag)
                    {
                        label_Joystick.ForeColor = Color.FromArgb(100, 100, 100);
                    }

                    break;
                case "label_Increase_Dead_Band":
                    label_Increase_Dead_Band.ForeColor = Color.FromArgb(150, 150, 150);
                    break;
                case "label_Decrease_Dead_Band":
                    label_Decrease_Dead_Band.ForeColor = Color.FromArgb(150, 150, 150);
                    break;
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            switch (label.Name)
            {
                case "label_X":
                    if (!x_Flag)
                    {
                        label_X.ForeColor = Color.FromArgb(64, 64, 64);
                    }

                    break;
                case "label_Y":
                    if (!y_Flag)
                    {
                        label_Y.ForeColor = Color.FromArgb(64, 64, 64);
                    }

                    break;
                case "label_Z":
                    if (!z_Flag)
                    {
                        label_Z.ForeColor = Color.FromArgb(64, 64, 64);
                    }

                    break;
                case "label_Joystick":
                    if (!joystick_Flag)
                    {
                        label_Joystick.ForeColor = Color.FromArgb(64, 64, 64);
                    }

                    break;
                case "label_Increase_Dead_Band":
                    label_Increase_Dead_Band.ForeColor = Color.FromArgb(64, 64, 64);
                    break;
                case "label_Decrease_Dead_Band":
                    label_Decrease_Dead_Band.ForeColor = Color.FromArgb(64, 64, 64);
                    break;
            }
        }

        private void Dead_Band_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (x_Flag)
            {
                offset_Plus = x_Offset_Plus;
                offset_Minus = x_Offset_Minus;
                switch (label.Name)
                {
                    case "label_Increase_Dead_Band":
                        x_Dead_Band += 10.0;
                        offset_Plus += 5.0;
                        offset_Minus -= 5.0;
                        break;
                    case "label_Decrease_Dead_Band":
                        if (x_Dead_Band != 0.0)
                        {
                            x_Dead_Band -= 10.0;
                            offset_Plus -= 5.0;
                            offset_Minus += 5.0;
                        }

                        break;
                }

                x_Offset_Plus = offset_Plus;
                x_Offset_Minus = offset_Minus;
                x_Slope_Plus = 1000.0 / (x_Max_Plus - x_Offset_Plus);
                x_Slope_Minus = 1000.0 / (x_Offset_Minus - x_Max_Minus);
            }

            if (y_Flag)
            {
                offset_Plus = y_Offset_Plus;
                offset_Minus = y_Offset_Minus;
                switch (label.Name)
                {
                    case "label_Increase_Dead_Band":
                        y_Dead_Band += 10.0;
                        offset_Plus += 5.0;
                        offset_Minus -= 5.0;
                        break;
                    case "label_Decrease_Dead_Band":
                        if (y_Dead_Band != 0.0)
                        {
                            y_Dead_Band -= 10.0;
                            offset_Plus -= 5.0;
                            offset_Minus += 5.0;
                        }

                        break;
                }

                y_Offset_Plus = offset_Plus;
                y_Offset_Minus = offset_Minus;
                y_Slope_Plus = 1000.0 / (y_Max_Plus - y_Offset_Plus);
                y_Slope_Minus = 1000.0 / (y_Offset_Minus - y_Max_Minus);
            }

            if (!z_Flag)
            {
                return;
            }

            offset_Plus = z_Offset_Plus;
            offset_Minus = z_Offset_Minus;
            switch (label.Name)
            {
                case "label_Increase_Dead_Band":
                    z_Dead_Band += 10.0;
                    offset_Plus += 5.0;
                    offset_Minus -= 5.0;
                    break;
                case "label_Decrease_Dead_Band":
                    if (z_Dead_Band != 0.0)
                    {
                        z_Dead_Band -= 10.0;
                        offset_Plus -= 5.0;
                        offset_Minus += 5.0;
                    }

                    break;
            }

            z_Offset_Plus = offset_Plus;
            z_Offset_Minus = offset_Minus;
            z_Slope_Plus = 1000.0 / (z_Max_Plus - z_Offset_Plus);
            z_Slope_Minus = 1000.0 / (z_Offset_Minus - z_Max_Minus);
        }

        private void Update_Output_Level_Bar(float x)
        {
            float num;
            if (joystick_Flag && joystick_Mode_Flag == 1)
            {
                chart_Transfer_Function.ChartAreas[0].AxisY.Maximum = 100.0;
                chart_Transfer_Function.ChartAreas[0].AxisY.Minimum = -100.0;
                chart_Transfer_Function.ChartAreas[0].AxisY.Interval = 20.0;
                chart_Transfer_Function.ChartAreas[0].AxisY.MinorGrid.Interval = 10.0;
                num = 100f;
            }
            else
            {
                chart_Transfer_Function.ChartAreas[0].AxisY.Maximum = 1000.0;
                chart_Transfer_Function.ChartAreas[0].AxisY.Minimum = -1000.0;
                chart_Transfer_Function.ChartAreas[0].AxisY.Interval = 200.0;
                chart_Transfer_Function.ChartAreas[0].AxisY.MinorGrid.Interval = 100.0;
                num = 1000f;
            }

            Bitmap bitmap = new Bitmap(5, 200);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            SolidBrush brush = new SolidBrush(Color.FromArgb(32, 32, 32));
            Rectangle rect = new Rectangle(0, 0, 5, 200);
            Rectangle rect2 = new Rectangle(0, 0, 4, 199);
            Pen pen = new Pen(Color.FromArgb(64, 64, 64), 0.5f);
            float num2 = bitmap.Width;
            float num3 = -1f * ((float)bitmap.Height / (2f * num)) * x + (float)(bitmap.Height / 2);
            RectangleF rect3 = (0f <= x && x <= num) ? new RectangleF(0f, num3, bitmap.Width, (float)(bitmap.Height / 2) - num3) : new RectangleF(0f, bitmap.Height / 2, bitmap.Width, num3 - (float)(bitmap.Height / 2));
            SolidBrush brush2 = new SolidBrush(Color.Gold);
            graphics.FillRectangle(brush, rect);
            graphics.FillRectangle(brush2, rect3);
            graphics.DrawRectangle(pen, rect2);
            Point[] array = new Point[2]
            {
                new Point(0, 100),
                new Point(5, 100)
            };
            Pen pen2 = new Pen(Color.Gold, 1f);
            if (x == 0f)
            {
                graphics.DrawLine(pen2, array[0], array[1]);
            }

            pictureBox2.Image = bitmap;
        }

    }
}
