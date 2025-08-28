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
using Zhaoxi.HotelRemoteControlCenter.Utils;

namespace Zhaoxi.HotelRemoteControlCenter.UControls
{
    public partial class UPanel : Panel
    {
        Rectangle rect;//绘制区域
        public UPanel()
        {
            InitializeComponent();
            //设置控件样式标志----绘制
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息，减少闪烁
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区，减少闪烁
            SetStyle(ControlStyles.UserPaint, true);//控件由其自身而不是操作系统绘制
            SetStyle(ControlStyles.ResizeRedraw, true);//控件调整其大小时重绘
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景
            rect = this.ClientRectangle;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            rect = this.ClientRectangle;
            this.Region = new Region(rect);
            rect.Width -= 1;
            rect.Height -= 1;
        }

        //属性扩展：背景色1、背景色2、边框粗细、边框颜色、圆角半径、渐变模式
        private Color bgColor = Color.Gray;
        /// <summary>
        /// 背景色（渐变色中，颜色1）
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件背景色")]
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                Invalidate();
            }
        }


        [DefaultValue(typeof(Color), "Transparent"), Description("控件背景颜色2")]
        private Color bgColor2 = Color.Transparent;
        public Color BgColor2
        {
            get { return bgColor2; }
            set
            {
                bgColor2 = value;
                Invalidate();
            }
        }

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


        [DefaultValue(typeof(int), "5"), Description("圆角弧度大小")]
        private int radius = 5;
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("渐变方式")]
        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //重绘外观：如果有边框，画边框、背景、内容
            Graphics g = e.Graphics;//绘图对象           
            g.SmoothingMode = SmoothingMode.HighQuality;  //呈现质量--高质量呈现 
            Rectangle rect1;//定义背景矩形
            GraphicsPath path = new GraphicsPath();//边框圆角路径
            GraphicsPath path2 = new GraphicsPath();//背景圆角路径
            if (radius > 0)//有圆角度
            {
                path = PaintClass.GetRoundRectangle(rect, radius);//圆角矩形路径
                if (borderWidth > 0)//有边框时
                {
                    g.FillPath(new SolidBrush(borderColor), path);//填充边框的圆角矩形
                     //内部背景区域矩形 
                    rect1 = new Rectangle(rect.X + borderWidth, rect.Y + borderWidth, rect.Width - 2 * borderWidth, rect.Height - 2 * borderWidth);
                    //生成内部矩形的圆角矩形路径
                    path2 = PaintClass.GetRoundRectangle(rect1, radius);
                }
                else //无边框
                {
                    path2 = path;
                    rect1 = rect;
                }
                //背景色填充
                if (bgColor2 != Color.Transparent) //渐变填充
                {
                    //渐变画刷
                    LinearGradientBrush bgBrush = new LinearGradientBrush(rect1, bgColor, bgColor2, gradientMode);
                    g.FillPath(bgBrush, path2);//填充背景
                }
                else
                {
                    //纯色填充
                    Brush b = new SolidBrush(bgColor);
                    g.FillPath(b, path2);
                }
            }
            else//没有圆角
            {
                if (borderWidth > 0)//有边框时
                {
                    g.FillRectangle(new SolidBrush(borderColor), rect);//填充边框矩形
                    //定义内部矩形结构
                    rect1 = new Rectangle(rect.X + borderWidth, rect.Y + borderWidth, rect.Width - 2 * borderWidth, rect.Height - 2 * borderWidth);
                }
                else //无边框
                {
                    rect1 = rect;
                }
                //背景色填充
                if (bgColor2 != Color.Transparent)
                {
                    //渐变画刷
                    LinearGradientBrush bgBrush = new LinearGradientBrush(rect1, bgColor, bgColor2, gradientMode);
                    g.FillRectangle(bgBrush, rect1);//填充背景
                }
                else
                {
                    Brush b = new SolidBrush(bgColor);
                    g.FillRectangle(b, rect1);
                }
            }
        }
    }
}
