namespace MutilChannels_Analog_Input
{
    partial class MianForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_parameter = new System.Windows.Forms.GroupBox();
            this.numericUpDown_sampleRate = new System.Windows.Forms.NumericUpDown();
            this.comboBox_channelNum = new System.Windows.Forms.ComboBox();
            this.comboBox_boardNum = new System.Windows.Forms.ComboBox();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.label_channelQuantity = new System.Windows.Forms.Label();
            this.label_cardNum = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.splitter_content = new System.Windows.Forms.Splitter();
            this.label_title = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.Splitter();
            this.easyChart_wave = new SeeSharpTools.JY.GUI.EasyChart();
            this.groupBox_parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_parameter
            // 
            this.groupBox_parameter.Controls.Add(this.numericUpDown_sampleRate);
            this.groupBox_parameter.Controls.Add(this.comboBox_channelNum);
            this.groupBox_parameter.Controls.Add(this.comboBox_boardNum);
            this.groupBox_parameter.Controls.Add(this.label_sampleRate);
            this.groupBox_parameter.Controls.Add(this.label_channelQuantity);
            this.groupBox_parameter.Controls.Add(this.label_cardNum);
            this.groupBox_parameter.Location = new System.Drawing.Point(788, 142);
            this.groupBox_parameter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_parameter.Name = "groupBox_parameter";
            this.groupBox_parameter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_parameter.Size = new System.Drawing.Size(212, 291);
            this.groupBox_parameter.TabIndex = 8;
            this.groupBox_parameter.TabStop = false;
            this.groupBox_parameter.Text = "基本参数设置";
            // 
            // numericUpDown_sampleRate
            // 
            this.numericUpDown_sampleRate.Location = new System.Drawing.Point(116, 234);
            this.numericUpDown_sampleRate.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDown_sampleRate.Size = new System.Drawing.Size(87, 25);
            this.numericUpDown_sampleRate.TabIndex = 5;
            this.numericUpDown_sampleRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // comboBox_channelNum
            // 
            this.comboBox_channelNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_channelNum.FormattingEnabled = true;
            this.comboBox_channelNum.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_channelNum.Location = new System.Drawing.Point(116, 153);
            this.comboBox_channelNum.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_channelNum.Name = "comboBox_channelNum";
            this.comboBox_channelNum.Size = new System.Drawing.Size(89, 23);
            this.comboBox_channelNum.TabIndex = 4;
            // 
            // comboBox_boardNum
            // 
            this.comboBox_boardNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_boardNum.FormattingEnabled = true;
            this.comboBox_boardNum.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox_boardNum.Location = new System.Drawing.Point(116, 69);
            this.comboBox_boardNum.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_boardNum.Name = "comboBox_boardNum";
            this.comboBox_boardNum.Size = new System.Drawing.Size(89, 23);
            this.comboBox_boardNum.TabIndex = 3;
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Location = new System.Drawing.Point(13, 241);
            this.label_sampleRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(100, 15);
            this.label_sampleRate.TabIndex = 2;
            this.label_sampleRate.Text = "采样率(S/s):";
            // 
            // label_channelQuantity
            // 
            this.label_channelQuantity.AutoSize = true;
            this.label_channelQuantity.Location = new System.Drawing.Point(13, 157);
            this.label_channelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_channelQuantity.Name = "label_channelQuantity";
            this.label_channelQuantity.Size = new System.Drawing.Size(76, 15);
            this.label_channelQuantity.TabIndex = 1;
            this.label_channelQuantity.Text = "通 道 数:";
            // 
            // label_cardNum
            // 
            this.label_cardNum.AutoSize = true;
            this.label_cardNum.Location = new System.Drawing.Point(13, 74);
            this.label_cardNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cardNum.Name = "label_cardNum";
            this.label_cardNum.Size = new System.Drawing.Size(76, 15);
            this.label_cardNum.TabIndex = 0;
            this.label_cardNum.Text = "板 卡 号:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_stop.Location = new System.Drawing.Point(911, 474);
            this.button_stop.Margin = new System.Windows.Forms.Padding(2);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(90, 53);
            this.button_stop.TabIndex = 10;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_start.Location = new System.Drawing.Point(804, 474);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(90, 53);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // splitter_content
            // 
            this.splitter_content.BackColor = System.Drawing.Color.White;
            this.splitter_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter_content.Location = new System.Drawing.Point(0, 121);
            this.splitter_content.Margin = new System.Windows.Forms.Padding(2);
            this.splitter_content.Name = "splitter_content";
            this.splitter_content.Size = new System.Drawing.Size(1031, 438);
            this.splitter_content.TabIndex = 13;
            this.splitter_content.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(32, 33);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(491, 48);
            this.label_title.TabIndex = 12;
            this.label_title.Text = "USB101多通道模拟采集实验";
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Margin = new System.Windows.Forms.Padding(2);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1031, 121);
            this.splitter.TabIndex = 11;
            this.splitter.TabStop = false;
            // 
            // easyChart_wave
            // 
            this.easyChart_wave.AxisYMax = double.NaN;
            this.easyChart_wave.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            this.easyChart_wave.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart_wave.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart_wave.FixAxisX = false;
            this.easyChart_wave.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart_wave.LegendVisible = true;
            this.easyChart_wave.Location = new System.Drawing.Point(0, 121);
            this.easyChart_wave.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart_wave.MajorGridEnabled = true;
            this.easyChart_wave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.easyChart_wave.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart_wave.MinorGridEnabled = false;
            this.easyChart_wave.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart_wave.Name = "easyChart_wave";
            this.easyChart_wave.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart_wave.SeriesNames = new string[] {
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
            this.easyChart_wave.Size = new System.Drawing.Size(770, 435);
            this.easyChart_wave.TabIndex = 15;
            this.easyChart_wave.XAxisLogarithmic = false;
            this.easyChart_wave.YAutoEnable = true;
            this.easyChart_wave.YAxisLogarithmic = false;
            // 
            // MianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 580);
            this.Controls.Add(this.easyChart_wave);
            this.Controls.Add(this.groupBox_parameter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.splitter_content);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.splitter);
            this.Name = "MianForm";
            this.Text = "MianForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MianForm_FormClosing);
            this.Load += new System.EventHandler(this.MianForm_Load);
            this.groupBox_parameter.ResumeLayout(false);
            this.groupBox_parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sampleRate)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_parameter;
        private System.Windows.Forms.NumericUpDown numericUpDown_sampleRate;
        private System.Windows.Forms.ComboBox comboBox_channelNum;
        private System.Windows.Forms.ComboBox comboBox_boardNum;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.Label label_channelQuantity;
        private System.Windows.Forms.Label label_cardNum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Splitter splitter_content;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Splitter splitter;
        private SeeSharpTools.JY.GUI.EasyChart easyChart_wave;
    }
}

