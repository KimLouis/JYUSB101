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
    public partial class AnalogInputForm : Form
    {
        #region Private Fields
        // 创建模拟采集任务
        private JYUSB101AITask aiTask;
        // 存放模拟采集到的数据，容量为100ms样点数
        private double[] readValue;
        #endregion

        #region Constructor
        // 初始化主窗口
        public AnalogInputForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        // 设置comboBox的Index默认值
        private void AnalogInputForm_Load(object sender, EventArgs e)
        {
            comboBox_boardNum.SelectedIndex = 0;
            comboBox_channelNum.SelectedIndex = 0;
        }
        #endregion




    }
}
