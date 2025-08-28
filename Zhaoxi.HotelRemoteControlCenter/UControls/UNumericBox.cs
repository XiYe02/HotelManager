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
    public partial class UNumericBox : UserControl
    {
        public UNumericBox()
        {
            InitializeComponent();
            ForeColor = Color.White;//数字的颜色白色
            NumCount = 3;
            CreateNumberItems();//创建数字项
        }



        //数字个数 、 数值、数字项的背景色、重写ForeColor、数字项间的间隔

        private int dValue;
        //数值
        public int Value
        {
            get { return dValue; }
            set
            {
                dValue = value;
                if (dValue.ToString().Length > numCount)
                    NumCount = dValue.ToString().Length;
                else
                    UpdateValue();//更新值
            }
        }


        private int numCount;
        //数字个数
        public int NumCount
        {
            get { return numCount; }
            set
            {
                numCount = value;
                //重新创建数字项
                CreateNumberItems();
            }
        }

        private Color itemBgColor = Color.Black;
        //数字项的背景色
        public Color ItemBgColor
        {
            get { return itemBgColor; }
            set
            {
                itemBgColor = value;
                foreach (Control c in panelNumbers.Controls)
                {
                    c.BackColor = itemBgColor;
                }
            }
        }

        private int itemSpace = 2;
        //数字项间的间隔
        public int ItemSpace
        {
            get { return itemSpace; }
            set
            {
                itemSpace = value;
                UNumericBox_SizeChanged(this, EventArgs.Empty);
            }
        }


        //更新数字的颜色
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                foreach (Control c in panelNumbers.Controls)
                {
                    c.ForeColor = base.ForeColor;
                }
            }
        }

        private void CreateNumberItems()
        {
            panelNumbers.Controls.Clear();//清空数字项
            int panelPaddingTop = panelNumbers.Padding.Top;
            int panelPaddingLeft = panelNumbers.Padding.Left;
            int itemHeight = panelNumbers.Height - 2 * panelPaddingTop;//项的高度
            int itemWidth = (panelNumbers.Width - 2 * panelPaddingLeft) / NumCount - 2 * itemSpace;//项的宽度
            string formatStr = "";
            for (int i = 1; i <= NumCount; i++)
            {
                formatStr += "0";
            }
            char[] strValues = Value.ToString(formatStr).ToArray();//格式化的数值的字符数组
            //第一个数字项的坐标值
            int locLeft = panelPaddingLeft + itemSpace;
            int locTop = panelPaddingTop;
            for (int i = 0; i < numCount; i++)
            {
                Label lblItem = new Label();
                lblItem.Size = new Size(itemWidth, itemHeight);
                lblItem.BackColor = itemBgColor;
                lblItem.ForeColor = ForeColor;
                lblItem.Location = new Point(locLeft + i * (itemWidth + 2 * itemSpace), locTop);
                lblItem.Text = strValues[i].ToString();
                lblItem.TextAlign = ContentAlignment.MiddleCenter;
                lblItem.Margin = new Padding(itemSpace);
                lblItem.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom);
                panelNumbers.Controls.Add(lblItem);
            }
        }

        private void UpdateValue()
        {
            string formatStr = "";
            for (int i = 1; i <= NumCount; i++)
            {
                formatStr += "0";
            }
            char[] strValues = Value.ToString(formatStr).ToArray();//格式化的数值的字符数组
            int j = 0;
            foreach (Control c in panelNumbers.Controls)
            {
                c.Text = strValues[j].ToString();
                j++;
            }
        }

        private void UNumericBox_SizeChanged(object sender, EventArgs e)
        {
            int panelPaddingTop = panelNumbers.Padding.Top;
            int panelPaddingLeft = panelNumbers.Padding.Left;
            int itemHeight = panelNumbers.Height - 2 * panelPaddingTop;//项的高度
            int itemWidth = (panelNumbers.Width - 2 * panelPaddingLeft) / NumCount - 2 * itemSpace;//项的宽度
                                                                                                   //第一个数字项的坐标值
            int locLeft = panelPaddingLeft + itemSpace;
            int locTop = panelPaddingTop;
            int i = 0;
            foreach (Control c in panelNumbers.Controls)
            {
                c.Size = new Size(itemWidth, itemHeight);
                c.Location = new Point(locLeft + i * (itemWidth + 2 * itemSpace), locTop);
                i++;
            }
        }
    }
}
