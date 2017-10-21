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
using SeeSharpTools.JY.ArrayUtility;

namespace MutilChannels_Analog_Input
{
    public partial class MianForm : Form
    {
        #region Private Fields
        // 创建多通道采集任务
        private JYUSB101AITask mutilAiTask;
        // 全局变量 存放当前用户Buffer数据
        double[,] readValue;
        // 全局变量 存放当前用户Buffer数据的转置用于显示
        double[,] displayValue;
        #endregion

        #region Constructor
        // 创建主窗体
        public MianForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        // 主窗口初始化
        private void MianForm_Load(object sender, EventArgs e)
        {
            comboBox_boardNum.SelectedIndex = 0;
            comboBox_channelNum.SelectedIndex = 0;
        }

        // 开始采集
        private void button_start_Click(object sender, EventArgs e)
        {
            // 新建任务
            mutilAiTask = new JYUSB101AITask(comboBox_boardNum.SelectedIndex);
            // 获取当前选择的通道数量
            int channelNumber = Convert.ToInt16(comboBox_channelNum.Text);
            // 添加通道
            for (int i = 0; i < channelNumber; i++)
            {
                mutilAiTask.AddChannel(i);
            }

            // 采集卡参数配置
            mutilAiTask.Mode = AIMode.Continuous;
            mutilAiTask.SampleRate = (double)numericUpDown_sampleRate.Value;
            // 分配readValue和displayValue内存
            readValue = new double[
                (int)mutilAiTask.SampleRate / 2,
                Convert.ToInt16(comboBox_channelNum.Text)];
            displayValue = new double[
                Convert.ToInt16(comboBox_channelNum.Text),
                (int)mutilAiTask.SampleRate / 2];
            // 开始采集
            mutilAiTask.Start();

            // 启动定时器，禁用配置按钮，状态栏显示
            timer1.Enabled = true;
            groupBox_parameter.Enabled = false;
            button_start.Enabled = false;
            toolStripStatusLabel.Text = "开始采集";
        }

        // 停止采集
        private void button_stop_Click(object sender, EventArgs e)
        {
            if (mutilAiTask != null)
            {
                mutilAiTask.Stop();
            }
            // 停止定时器，启用配置按钮，状态栏显示
            timer1.Enabled = false;
            groupBox_parameter.Enabled = true;
            button_start.Enabled = true;
            toolStripStatusLabel.Text = "停止采集";
        }

        // 程序结束清理
        private void MianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mutilAiTask != null)
            {
                mutilAiTask.Stop();
            }
        }

        // 设置定时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (mutilAiTask.AvailableSamples >= readValue.Length)
            {
                try
                {
                    mutilAiTask.ReadData(ref readValue, -1);
                    toolStripStatusLabel.Text = "数据读取中...";
                }
                catch (JYDriverException ex)
                {
                    timer1.Enabled = true;
                    toolStripStatusLabel.Text = "数据读取错误";
                    MessageBox.Show(ex.Message);
                }

                // 绘制图像
                ArrayManipulation.Transpose(readValue,ref displayValue);
                easyChart_wave.Plot(displayValue);
            }
            timer1.Enabled = true;
        }
        #endregion




    }
}
