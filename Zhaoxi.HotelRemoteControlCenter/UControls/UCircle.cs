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
    public partial class UCircle : Label
    {
        Rectangle rect;//绘制区域
        public UCircle()
        {
            InitializeComponent();
            //设置控件样式标志----绘制
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息，减少闪烁
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区，减少闪烁
            SetStyle(ControlStyles.UserPaint, true);//控件由其自身而不是操作系统绘制
            SetStyle(ControlStyles.ResizeRedraw, true);//控件调整其大小时重绘
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景
            rect = this.ClientRectangle;
            this.BackColor = Color.Transparent;
            this.Size = new Size(30, 30);

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Width = Height;
            rect = this.ClientRectangle;
            this.Region = new Region(rect);
        }

        public override string Text { get => ""; }

        public override bool AutoSize { get => false; }

        private Color borderColor = Color.Gray;
        [DefaultValue(typeof(Color), "Gray"), Description("控件边框颜色")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                if (borderWidth > 0)
                    Invalidate();
            }
        }

        private int borderWidth = 0;
        [DefaultValue(typeof(int), "0"), Description("控件边框粗细")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //重绘外观：如果有边框，画边框、背景、内容
            Graphics g = e.Graphics;//绘图对象           
            g.SmoothingMode = SmoothingMode.HighQuality;  //呈现质量--高质量呈现 

            //画圆
            //圆形所在矩形
            Rectangle rect1 = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 2, Height - 2);
            if(borderWidth>0)
            {
                g.FillEllipse(new SolidBrush(borderColor), rect1);//填充边框
                Rectangle rectCenter=new Rectangle(rect1.X+borderWidth,rect1.Y+borderWidth,rect1.Width-2*borderWidth, rect1.Height-2*borderWidth);
                g.FillEllipse(new SolidBrush(ForeColor), rectCenter);//填充圆形背景
            }
            else
            {
                g.FillEllipse(new SolidBrush(ForeColor), rect1);//填充圆形背景
            }
        }
    }
}
