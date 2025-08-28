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
    public partial class USquareSwitch : UserControl
    {
        public USquareSwitch()
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
            Size = new Size(100, 40);
        }

        //事件：开关切换事件
        public event EventHandler CheckedChanged;//形状状态改变事件

        private bool s_checked;
        [DefaultValue(typeof(bool), "False"), Description("开关状态")]
        public bool Checked
        {
            get { return s_checked; }
            set
            {
                s_checked = value;
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
            set
            {
                stateTexts = value;
                Invalidate();
            }
        }

        private int radius = 5;
        [DefaultValue(typeof(int), "5"), Description("控件的圆角半径"), Category("自定义")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;//绘图对象           
            g.SmoothingMode = SmoothingMode.HighQuality;  //呈现质量--高质量呈现 

            //背景色
            var bgColor = s_checked ? trueColor : falseColor;
            //形状路径 
            GraphicsPath path = new GraphicsPath();

            //圆角的直径
            int d = 2 * radius;

            //向path中添加4段圆弧
            //左上角：起始角度：180  旋转角度：90
            path.AddArc(0, 0, d, d, 180f, 90f);
            //右上角：起始角度：270  旋转角度：90
            path.AddArc(Width - d - 1, 0, d, d, 270f, 90f);
            //右下角：起始角度：0  旋转角度：90
            path.AddArc(Width - d - 1, Height - d - 1, d, d, 0f, 90f);
            //左下角：起始角度：90  旋转角度：90
            path.AddArc(0, Height - d - 1, d, d, 90f, 90f);
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
            if (s_checked) //开关的外观
            {
                //右边画圆角正方形，里边画小圆，左边画文本
                GraphicsPath path2 = new GraphicsPath();
                //左上角：起始角度：180  旋转角度：90
                path2.AddArc(Width - 1 - Height + 2, 2, d, d, 180f, 90f);
                //右上角：起始角度：270  旋转角度：90
                path2.AddArc(Width - 1 - 2 - d, 2, d, d, 270f, 90f);
                //右下角：起始角度：0  旋转角度：90
                path2.AddArc(Width - 1 - 2 - d, Height - 1 - 2 - d, d, d, 0f, 90f);
                //左下角：起始角度：90  旋转角度：90
                path2.AddArc(Width - 1 - Height + 2, Height - 1 - 2 - d, d, d, 90f, 90f);
                //填充圆角正方形，白色
                g.FillPath(Brushes.White, path2);
                //小圆  直径：正方形边长的一半：(Height-4)/2
                Rectangle ellipseRect = new Rectangle(Width - Height + 2 + (Height - 4) / 4, (Height - 4) / 4 + 2, (Height - 4) / 2, (Height - 4) / 2);
                //画圆的边线
                g.DrawEllipse(new Pen(bgColor,2), ellipseRect);
                if (!string.IsNullOrEmpty(text))
                {
                    //文本尺寸
                    SizeF fontSize = g.MeasureString(text.Replace(' ', 'A'), Font);
                    float textPosY = ((float)Height - fontSize.Height) / 2 + 2;//左上角的Y值
                    g.DrawString(text, Font, Brushes.White, new PointF((float)(Height - 2 - 4) / 2, textPosY));//画文字
                }
            }
            else//关时的外观
            {
                //左边画圆角正方形，里边画小圆，右边文本   
                GraphicsPath path2 = new GraphicsPath();
                //左上角：起始角度：180  旋转角度：90
                path2.AddArc(2, 2, d, d, 180f, 90f);
                //右上角：起始角度：270  旋转角度：90
                path2.AddArc(Height - 2 - d, 2, d, d, 270f, 90f);
                //右下角：起始角度：0  旋转角度：90
                path2.AddArc(Height - 2 - d, Height - 1 - 2 - d, d, d, 0f, 90f);
                //左下角：起始角度：90  旋转角度：90
                path2.AddArc(2, Height - 1 - 2 - d, d, d, 90f, 90f);
                //填充正方形
                g.FillPath(Brushes.White, path2);
                //小圆  直径：(Height-4)/2
                Rectangle ellipseRect = new Rectangle(2 + (Height - 4) / 4, (Height - 4) / 4 + 2, (Height - 4) / 2, (Height - 4) / 2);
                g.DrawEllipse(new Pen(bgColor, 2), ellipseRect);
                if (!string.IsNullOrEmpty(text))
                {
                    SizeF fontSize = g.MeasureString(text.Replace(' ', 'A'), Font);
                    float textPosY = ((float)Height - fontSize.Height) / 2 + 2;//左上角的Y值
                                                                               // x: 宽-2-右边半径宽-文字的宽度+4
                    g.DrawString(text, Font, Brushes.White, new PointF((float)(Width - 1 - (Height - 2) / 2 - fontSize.Width), textPosY));//画文字
                }
                
            }
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
