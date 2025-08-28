using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    [DefaultEvent("CheckedChanged")]
    public partial class USwitch : UserControl
    {
        public USwitch()
        {
            InitializeComponent();
            //设置控件样式标志----绘制
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息，减少闪烁
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区，减少闪烁
            SetStyle(ControlStyles.UserPaint, true);//控件由其自身而不是操作系统绘制
            SetStyle(ControlStyles.ResizeRedraw, true);//控件调整其大小时重绘
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景
            BackColor = Color.Transparent;
            MouseDown += USwitch_MouseDown;
        }

        //事件：开关切换事件
        public event EventHandler CheckedChanged;//形状状态改变事件
        //属性：Checked  TrueColor  FalseColor  StateTexts---开、关

        private bool s_checked;
        [DefaultValue(typeof(bool), "False"), Description("开关状态")]
        public bool Checked
        {
            get { return s_checked; }
            set { s_checked = value;
                Invalidate();
            }
        }


        private Color trueColor = Color.Orange;
        [DefaultValue(typeof(Color), "Orange"), Description("状态为开时的背景颜色")]
        public Color TrueColor
        {
            get { return trueColor; }
            set
            {
                trueColor = value;
                Invalidate();
            }
        }

        private Color falseColor = Color.Gray;
        [DefaultValue(typeof(Color), "Gray"), Description("状态为关时的背景颜色")]
        public Color FalseColor
        {
            get { return falseColor; }
            set
            {
                falseColor = value;
                Invalidate();
            }
        }

        private string[] stateTexts;
        [Description("状态文本数组，长度必须为2")]
        public string[] StateTexts
        {
            get { return stateTexts; }
            set { stateTexts = value;
                Invalidate();
            }
        }


        private void USwitch_MouseDown(object sender, MouseEventArgs e)
        {
            CheckedChanged?.Invoke(this, new EventArgs());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;//绘图对象           
            g.SmoothingMode = SmoothingMode.HighQuality;  //呈现质量--高质量呈现 

            //背景色
            var bgColor=s_checked?trueColor:falseColor;
            //形状路径 
            GraphicsPath path = new GraphicsPath();
            //上边线
            path.AddLine(new Point((Height-2) / 2, 1), new Point(Width - (Height-2) / 2, 1));
            //右边半圆弧
            path.AddArc(new Rectangle(Width - Height - 1, 1, Height - 2, Height - 2), -90, 180);
            //下边线
            path.AddLine(new Point(Width - (Height - 2) / 2, Height - 1), new Point((Height - 2) / 2, Height - 1));
            //左边半圆弧
            path.AddArc(new Rectangle(1, 1, Height - 2, Height - 2), 90, 180);
            //填充背景
            g.FillPath(new SolidBrush(bgColor), path);

            //状态文本
            string text = string.Empty;
            if (stateTexts != null && stateTexts.Length == 2)
            {
                if (s_checked)
                    text = stateTexts[0];
                else
                    text = stateTexts[1];
            }

            //绘制状态为开时/关时的内部形状
            if(s_checked) //开关的外观
            {
                //右边大圆，左边文本   
                g.FillEllipse(Brushes.White, new Rectangle(Width - Height - 1 + 2, 1 + 2, Height - 2 - 4, Height - 2 - 4));
                if(!string.IsNullOrEmpty(text))
                {
                    //文本尺寸
                    SizeF fontSize = g.MeasureString(text.Replace(' ', 'A'), Font);
                    float textPosY = ((float)Height - fontSize.Height) / 2 + 2;//左上角的Y值
                    g.DrawString(text, Font, Brushes.White, new PointF((float)(Height - 2 - 4) / 2, textPosY));//画文字
                }
            }
            else//关时的外观
            {
                //左边大圆，右边文本   
                g.FillEllipse(Brushes.White, new Rectangle(1 + 2, 1 + 2, Height - 2 - 4, Height - 2 - 4));
                SizeF fontSize = g.MeasureString(text.Replace(' ', 'A'), Font);
                float textPosY = ((float)Height - fontSize.Height) / 2 + 2;//左上角的Y值
                // x: 宽-2-右边半径宽-文字的宽度+4
                g.DrawString(text, Font, Brushes.White, new PointF((float)(Width-1-(Height-2)/2-fontSize.Width), textPosY));//画文字
            }
        }
    }
}
