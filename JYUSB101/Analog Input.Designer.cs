namespace JYUSB101
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chart_wave = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_parameter = new System.Windows.Forms.GroupBox();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.label_channelNum = new System.Windows.Forms.Label();
            this.label_cardNum = new System.Windows.Forms.Label();
            this.comboBox_boardNum = new System.Windows.Forms.ComboBox();
            this.comboBox_channelNum = new System.Windows.Forms.ComboBox();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.splitter = new System.Windows.Forms.Splitter();
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox_parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_wave
            // 
            this.chart_wave.AxisYMax = double.NaN;
            this.chart_wave.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.chart_wave.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.chart_wave.EasyChartBackColor = System.Drawing.Color.White;
            this.chart_wave.FixAxisX = false;
            this.chart_wave.Font = new System.Drawing.Font("宋体", 10F);
            this.chart_wave.LegendBackColor = System.Drawing.Color.Transparent;
            this.chart_wave.LegendVisible = true;
            this.chart_wave.Location = new System.Drawing.Point(0, 176);
            this.chart_wave.MajorGridColor = System.Drawing.Color.Black;
            this.chart_wave.MajorGridEnabled = true;
            this.chart_wave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_wave.MinorGridColor = System.Drawing.Color.Black;
            this.chart_wave.MinorGridEnabled = false;
            this.chart_wave.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.chart_wave.Name = "chart_wave";
            this.chart_wave.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.chart_wave.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.chart_wave.Size = new System.Drawing.Size(1077, 613);
            this.chart_wave.TabIndex = 0;
            this.chart_wave.XAxisLogarithmic = false;
            this.chart_wave.YAutoEnable = true;
            this.chart_wave.YAxisLogarithmic = false;
            // 
            // groupBox_parameter
            // 
            this.groupBox_parameter.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_parameter.Controls.Add(this.comboBox_channelNum);
            this.groupBox_parameter.Controls.Add(this.comboBox_boardNum);
            this.groupBox_parameter.Controls.Add(this.label_sampleRate);
            this.groupBox_parameter.Controls.Add(this.label_channelNum);
            this.groupBox_parameter.Controls.Add(this.label_cardNum);
            this.groupBox_parameter.Location = new System.Drawing.Point(1084, 176);
            this.groupBox_parameter.Name = "groupBox_parameter";
            this.groupBox_parameter.Size = new System.Drawing.Size(292, 407);
            this.groupBox_parameter.TabIndex = 1;
            this.groupBox_parameter.TabStop = false;
            this.groupBox_parameter.Text = "基本参数设置";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(18, 337);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(139, 21);
            this.label_sampleRate.TabIndex = 2;
            this.label_sampleRate.Text = "采样率(S/s):";
            // 
            // label_channelNum
            // 
            this.label_channelNum.AutoSize = true;
            this.label_channelNum.Location = new System.Drawing.Point(18, 220);
            this.label_channelNum.Name = "label_channelNum";
            this.label_channelNum.Size = new System.Drawing.Size(106, 21);
            this.label_channelNum.TabIndex = 1;
            this.label_channelNum.Text = "通 道 号:";
            // 
            // label_cardNum
            // 
            this.label_cardNum.AutoSize = true;
            this.label_cardNum.Location = new System.Drawing.Point(18, 103);
            this.label_cardNum.Name = "label_cardNum";
            this.label_cardNum.Size = new System.Drawing.Size(106, 21);
            this.label_cardNum.TabIndex = 0;
            this.label_cardNum.Text = "板 卡 号:";
            // 
            // comboBox_boardNum
            // 
            this.comboBox_boardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardNum.FormattingEnabled = true;
            this.comboBox_boardNum.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_boardNum.Location = new System.Drawing.Point(160, 97);
            this.comboBox_boardNum.Name = "comboBox_boardNum";
            this.comboBox_boardNum.Size = new System.Drawing.Size(121, 29);
            this.comboBox_boardNum.TabIndex = 3;
            // 
            // comboBox_channelNum
            // 
            this.comboBox_channelNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNum.FormattingEnabled = true;
            this.comboBox_channelNum.Items.AddRange(new object[]{
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7"
            });
            this.comboBox_channelNum.Location = new System.Drawing.Point(160, 214);
            this.comboBox_channelNum.Name = "comboBox_channelNum";
            this.comboBox_channelNum.Size = new System.Drawing.Size(121, 29);
            this.comboBox_channelNum.TabIndex = 4;
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(160, 328);
            this.numericUpDown_sampleRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_sampleRate.Name = "numericUpDown_sampleRate";
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(1106, 670);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(124, 74);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(1252, 670);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(124, 74);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1397, 170);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(44, 46);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(533, 67);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "USB101模拟采集实验";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1397, 791);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox_parameter);
            this.Controls.Add(this.chart_wave);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnalogInputForm_Load);
            this.groupBox_parameter.ResumeLayout(false);
            this.groupBox_parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.EasyChart chart_wave;
        private System.Windows.Forms.GroupBox groupBox_parameter;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.Label label_channelNum;
        private System.Windows.Forms.Label label_cardNum;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.ComboBox comboBox_channelNum;
        private System.Windows.Forms.ComboBox comboBox_boardNum;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Label label_title;
    }
}

