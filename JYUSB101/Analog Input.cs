using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JYUSB101;

namespace JYUSB101
{
    public partial class MainForm : Form
    {
        #region Private Fields
        // 创建模拟采集任务
        private JYUSB101AITask aiTask;
        // 存放模拟采集到的数据，容量为100ms样点数
        private double[] readValue;
        #endregion

        #region Constructor
        // 初始化主窗口
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler

        // 设置comboBox的Index默认值
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_boardNum.SelectedIndex = 0;
            comboBox_channelNum.SelectedIndex = 0;
        }

        // 启动采集
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                // 新建测量任务
                aiTask = new JYUSB101AITask(comboBox_boardNum.SelectedIndex);
                // 添加通道
                aiTask.AddChannel(comboBox_channelNum.SelectedIndex);
                // 配置基本参数
                // 连续采集模式
                aiTask.Mode = AIMode.Continuous;
                // 设置采样率 Sample/s
                aiTask.SampleRate = (double)numericUpDown_sampleRate.Value;
                // 设置读取数量，默认设为采样率一半 Sample/s
                readValue = new double[(int)aiTask.SampleRate / 2];
                // 开始测量(调用timer)
                aiTask.Start();
                // 启动定时器
                timer1.Enabled = true;
                // 禁用参数配置和开始按钮
                groupBox_parameter.Enabled = false;
                button_start.Enabled = false;
                toolStripStatusLabel.Text = "开始采集";
            }
            catch (JYDriverException ex)
            {
                toolStripStatusLabel.Text = "任务失败";
                MessageBox.Show(ex.Message);
            }
        }

        // 停止采集
        private void button_stop_Click(object sender, EventArgs e)
        {
            if (aiTask != null)
            {
                aiTask.Stop();
            }
            //
            timer1.Enabled = false;
            groupBox_parameter.Enabled = true;
            button_start.Enabled = true;
            toolStripStatusLabel.Text = "停止采集";
        }


        // 关闭窗口
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 判断是否任务存在
            if (aiTask != null)
            {
                aiTask.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //如果本地缓冲区数据足够则读取数据并显示，如果不够，返回
            if (aiTask.AvailableSamples >= readValue.Length)
            {
                try
                {
                    //读取资料存储在readValue中
                    aiTask.ReadData(ref readValue, readValue.Length, -1);
                    toolStripStatusLabel.Text = "正在读取数据中...";
                }
                catch (JYDriverException ex)
                {
                    timer1.Enabled = false;
                    toolStripStatusLabel.Text = "读取数据失败";
                    //驱动错误信息显示
                    MessageBox.Show(ex.Message);

                }
                //画图
                easychart_wave.Plot(readValue);
            }
            timer1.Enabled = true;
        }
        #endregion

        private void comboBox_ChanNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "提示：输入方式为Pseudodifferential时可使用的通道号为0—7";
        }

    }
}
