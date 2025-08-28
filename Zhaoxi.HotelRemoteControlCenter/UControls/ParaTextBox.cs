using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    [DefaultEvent("ParaTextBoxDClick")]
    public partial class ParaTextBox : Label
    {
        public ParaTextBox()
        {
            InitializeComponent();
        }

        //属性：数据值 、单位 、参数名

        string valStr = "";

        private decimal d_value;
        //数据值
        public decimal Value
        {
            get { return d_value; }
            set
            {
                d_value = value;
                FormatValue();
            }
        }

        private string unit;
        //单位
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                FormatValue();
            }
        }

        private int decimalCount;
        //小数位数
        public int DecimalCount
        {
            get { return decimalCount; }
            set
            {
                decimalCount = value;
                if (value > 0)
                {
                    valStr = "0.";
                    for (int i = 1; i <= decimalCount; i++)
                    {
                        valStr += "0";
                    }
                }
            }
        }
        //参数名
        public string ParaName { get; set; }

        public override string Text { get => base.Text; }
        public override ContentAlignment TextAlign { get => ContentAlignment.MiddleCenter; }

        //事件
        public event EventHandler<PTextBoxArgs> ParaTextBoxDClick;//信息框双击事件

        private void FormatValue()
        {
            if (valStr == "")
                Text = d_value + " " + unit;
            else
                Text = d_value.ToString(valStr) + " " + unit;
        }

        //双击事件引发
        private void ParaTextBox_DoubleClick(object sender, EventArgs e)
        {
            ParaTextBoxDClick?.Invoke(this, new PTextBoxArgs(Value));
        }

      
    }
}
