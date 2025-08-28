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
    public partial class VParaTextBox : UserControl
    {
        public VParaTextBox()
        {
            InitializeComponent();
        }

        string valStr = "";
        //属性：数据值、单位文本、小数位数、值字体、文本字体、值颜色、文本颜色

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



        //单位描述
        public string UnitNote
        {
            get { return lblUnit.Text; }
            set
            {
                lblUnit.Text = value;
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

        //数据值的字体
        public Font ValueFont
        {
            get { return lblValue.Font; }
            set { lblValue.Font = value; }
        }

        //单位描述的字体
        public Font UnitFont
        {
            get { return lblUnit.Font; }
            set { lblUnit.Font = value; }
        }

        //数据值的文字颜色
        public Color ValueFColor
        {
            get { return lblValue.ForeColor; }
            set { lblValue.ForeColor = value; }
        }

        //单位文本的文字颜色
        public Color UnitFColor
        {
            get { return lblUnit.ForeColor; }
            set { lblUnit.ForeColor = value; }
        }

        private void FormatValue()
        {
            if (valStr == "")
                lblValue.Text = d_value.ToString();
            else 
                lblValue.Text = d_value.ToString(valStr) ;
        }
    }
}
