namespace Joystick_2023_Control
{
    partial class Joystick_2023
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joystick_2023));
            this.chart_Transfer_Function = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer_Update_Chart = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Set_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox_Set_Zero = new System.Windows.Forms.PictureBox();
            this.pictureBox_Set_Max = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.label_Joystick = new System.Windows.Forms.Label();
            this.label_Decrease_Dead_Band = new System.Windows.Forms.Label();
            this.label_Increase_Dead_Band = new System.Windows.Forms.Label();
            this.label_Plus = new System.Windows.Forms.Label();
            this.label_Minus = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Transfer_Function)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Set_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Set_Zero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Set_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_button)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Transfer_Function
            // 
            this.chart_Transfer_Function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chart_Transfer_Function.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisX.Interval = 500D;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.Maximum = 2000D;
            chartArea3.AxisX.Minimum = -2000D;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.IntervalOffset = 100D;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.Interval = 200D;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.Maximum = 1000D;
            chartArea3.AxisY.Minimum = -1000D;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.Interval = 100D;
            chartArea3.AxisY.MinorGrid.IntervalOffset = double.NaN;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BorderColor = System.Drawing.Color.DimGray;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Gray;
            this.chart_Transfer_Function.ChartAreas.Add(chartArea3);
            this.chart_Transfer_Function.Location = new System.Drawing.Point(15, 51);
            this.chart_Transfer_Function.Name = "chart_Transfer_Function";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Gold;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Name = "Series2";
            this.chart_Transfer_Function.Series.Add(series5);
            this.chart_Transfer_Function.Series.Add(series6);
            this.chart_Transfer_Function.Size = new System.Drawing.Size(323, 301);
            this.chart_Transfer_Function.TabIndex = 18;
            this.chart_Transfer_Function.Text = "Transfer_Function";
            // 
            // timer_Update_Chart
            // 
            this.timer_Update_Chart.Enabled = true;
            this.timer_Update_Chart.Tick += new System.EventHandler(this.timer_Update_Chart_Tick);
            // 
            // pictureBox_Set_Min
            // 
            this.pictureBox_Set_Min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Set_Min.Image")));
            this.pictureBox_Set_Min.Location = new System.Drawing.Point(68, 32);
            this.pictureBox_Set_Min.Name = "pictureBox_Set_Min";
            this.pictureBox_Set_Min.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_Set_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Set_Min.TabIndex = 22;
            this.pictureBox_Set_Min.TabStop = false;
            this.pictureBox_Set_Min.Click += new System.EventHandler(this.pictureBox_Set_Click);
            this.pictureBox_Set_Min.MouseEnter += new System.EventHandler(this.pictureBox_Set_MouseEnter);
            this.pictureBox_Set_Min.MouseLeave += new System.EventHandler(this.pictureBox_Set_MouseLeave);
            // 
            // pictureBox_Set_Zero
            // 
            this.pictureBox_Set_Zero.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Set_Zero.Image")));
            this.pictureBox_Set_Zero.Location = new System.Drawing.Point(185, 33);
            this.pictureBox_Set_Zero.Name = "pictureBox_Set_Zero";
            this.pictureBox_Set_Zero.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_Set_Zero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Set_Zero.TabIndex = 21;
            this.pictureBox_Set_Zero.TabStop = false;
            this.pictureBox_Set_Zero.Click += new System.EventHandler(this.pictureBox_Set_Click);
            this.pictureBox_Set_Zero.MouseEnter += new System.EventHandler(this.pictureBox_Set_MouseEnter);
            this.pictureBox_Set_Zero.MouseLeave += new System.EventHandler(this.pictureBox_Set_MouseLeave);
            // 
            // pictureBox_Set_Max
            // 
            this.pictureBox_Set_Max.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Set_Max.Image")));
            this.pictureBox_Set_Max.Location = new System.Drawing.Point(300, 32);
            this.pictureBox_Set_Max.Name = "pictureBox_Set_Max";
            this.pictureBox_Set_Max.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_Set_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Set_Max.TabIndex = 20;
            this.pictureBox_Set_Max.TabStop = false;
            this.pictureBox_Set_Max.Click += new System.EventHandler(this.pictureBox_Set_Click);
            this.pictureBox_Set_Max.MouseEnter += new System.EventHandler(this.pictureBox_Set_MouseEnter);
            this.pictureBox_Set_Max.MouseLeave += new System.EventHandler(this.pictureBox_Set_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_X.Location = new System.Drawing.Point(172, 7);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(15, 19);
            this.label_X.TabIndex = 14;
            this.label_X.Text = "X";
            this.toolTip1.SetToolTip(this.label_X, "Select X Graph");
            this.label_X.Click += new System.EventHandler(this.label_Click);
            this.label_X.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_X.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Y.Location = new System.Drawing.Point(197, 7);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(15, 19);
            this.label_Y.TabIndex = 15;
            this.label_Y.Text = "Y";
            this.toolTip1.SetToolTip(this.label_Y, "Select Y Graph");
            this.label_Y.Click += new System.EventHandler(this.label_Click);
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Z.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Z.Location = new System.Drawing.Point(222, 7);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(15, 19);
            this.label_Z.TabIndex = 17;
            this.label_Z.Text = "Z";
            this.toolTip1.SetToolTip(this.label_Z, "Select Z Graph");
            this.label_Z.Click += new System.EventHandler(this.label_Click);
            // 
            // label_Joystick
            // 
            this.label_Joystick.AutoSize = true;
            this.label_Joystick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label_Joystick.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Joystick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Joystick.Location = new System.Drawing.Point(245, 8);
            this.label_Joystick.Name = "label_Joystick";
            this.label_Joystick.Size = new System.Drawing.Size(22, 17);
            this.label_Joystick.TabIndex = 16;
            this.label_Joystick.Text = "o";
            this.label_Joystick.Click += new System.EventHandler(this.label_Click);
            this.label_Joystick.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Joystick.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_Decrease_Dead_Band
            // 
            this.label_Decrease_Dead_Band.AutoSize = true;
            this.label_Decrease_Dead_Band.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Decrease_Dead_Band.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Decrease_Dead_Band.Location = new System.Drawing.Point(278, 8);
            this.label_Decrease_Dead_Band.Name = "label_Decrease_Dead_Band";
            this.label_Decrease_Dead_Band.Size = new System.Drawing.Size(25, 19);
            this.label_Decrease_Dead_Band.TabIndex = 25;
            this.label_Decrease_Dead_Band.Text = "3";
            this.toolTip1.SetToolTip(this.label_Decrease_Dead_Band, "Dead Band");
            this.label_Decrease_Dead_Band.Click += new System.EventHandler(this.Dead_Band_Click);
            this.label_Decrease_Dead_Band.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Decrease_Dead_Band.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_Increase_Dead_Band
            // 
            this.label_Increase_Dead_Band.AutoSize = true;
            this.label_Increase_Dead_Band.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_Increase_Dead_Band.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Increase_Dead_Band.Location = new System.Drawing.Point(298, 8);
            this.label_Increase_Dead_Band.Name = "label_Increase_Dead_Band";
            this.label_Increase_Dead_Band.Size = new System.Drawing.Size(25, 19);
            this.label_Increase_Dead_Band.TabIndex = 26;
            this.label_Increase_Dead_Band.Text = "4";
            this.toolTip1.SetToolTip(this.label_Increase_Dead_Band, "Dead Band");
            this.label_Increase_Dead_Band.Click += new System.EventHandler(this.Dead_Band_Click);
            this.label_Increase_Dead_Band.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label_Increase_Dead_Band.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label_Plus
            // 
            this.label_Plus.AutoSize = true;
            this.label_Plus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Plus.Location = new System.Drawing.Point(293, 335);
            this.label_Plus.Name = "label_Plus";
            this.label_Plus.Size = new System.Drawing.Size(35, 13);
            this.label_Plus.TabIndex = 28;
            this.label_Plus.Text = "label3";
            // 
            // label_Minus
            // 
            this.label_Minus.AutoSize = true;
            this.label_Minus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Minus.Location = new System.Drawing.Point(127, 334);
            this.label_Minus.Name = "label_Minus";
            this.label_Minus.Size = new System.Drawing.Size(35, 13);
            this.label_Minus.TabIndex = 27;
            this.label_Minus.Text = "label2";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label_Title.Location = new System.Drawing.Point(3, 3);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(79, 24);
            this.label_Title.TabIndex = 23;
            this.label_Title.Text = " Calibrator";
            // 
            // pictureBox_button
            // 
            this.pictureBox_button.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_button.Image")));
            this.pictureBox_button.Location = new System.Drawing.Point(151, 14);
            this.pictureBox_button.Name = "pictureBox_button";
            this.pictureBox_button.Size = new System.Drawing.Size(10, 10);
            this.pictureBox_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_button.TabIndex = 30;
            this.pictureBox_button.TabStop = false;
            // 
            // Joystick_2023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pictureBox_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Plus);
            this.Controls.Add(this.label_Minus);
            this.Controls.Add(this.label_Increase_Dead_Band);
            this.Controls.Add(this.label_Decrease_Dead_Band);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_Set_Min);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Set_Zero);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.pictureBox_Set_Max);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.label_Joystick);
            this.Controls.Add(this.chart_Transfer_Function);
            this.Name = "Joystick_2023";
            this.Size = new System.Drawing.Size(351, 350);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Transfer_Function)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Set_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Set_Zero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Set_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Transfer_Function;
        private System.Windows.Forms.Timer timer_Update_Chart;
        private System.Windows.Forms.PictureBox pictureBox_Set_Min;
        private System.Windows.Forms.PictureBox pictureBox_Set_Zero;
        private System.Windows.Forms.PictureBox pictureBox_Set_Max;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.Label label_Joystick;
        private System.Windows.Forms.Label label_Decrease_Dead_Band;
        private System.Windows.Forms.Label label_Increase_Dead_Band;
        private System.Windows.Forms.Label label_Plus;
        private System.Windows.Forms.Label label_Minus;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_button;
    }
}
