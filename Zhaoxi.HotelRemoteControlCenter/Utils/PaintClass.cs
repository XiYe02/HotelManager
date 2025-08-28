using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.HotelRemoteControlCenter.Utils
{
    public static class PaintClass
    {
        /// <summary>
        /// 根据矩形画圆角
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="r">圆角度半径</param>
        /// <returns></returns>
        public static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = 2 * r;
            // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
            GraphicsPath gp = new GraphicsPath();
            if (l > rectangle.Height)
                l = rectangle.Height;

            //上边直线
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            //右上角圆弧
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);
            //右边竖线
            if (l < rectangle.Height)
                gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            //右下角圆弧
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);
            //下边直线
            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            //左下角圆弧
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);
            //左边竖线
            if (l < rectangle.Height)
                gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            //左上角圆弧
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
            return gp;
        }

        public static void Paint(this object sender, PaintEventArgs e)
        {
            Form form = ((Form)sender);
            List<Point> list = new List<Point>();
            int width = form.Width;
            int height = form.Height;

            //左上
            list.Add(new Point(0, 5));
            list.Add(new Point(1, 5));
            list.Add(new Point(1, 3));
            list.Add(new Point(2, 3));
            list.Add(new Point(2, 2));
            list.Add(new Point(3, 2));
            list.Add(new Point(3, 1));
            list.Add(new Point(5, 1));
            list.Add(new Point(5, 0));
            //右上
            list.Add(new Point(width - 5, 0));
            list.Add(new Point(width - 5, 1));
            list.Add(new Point(width - 3, 1));
            list.Add(new Point(width - 3, 2));
            list.Add(new Point(width - 2, 2));
            list.Add(new Point(width - 2, 3));
            list.Add(new Point(width - 1, 3));
            list.Add(new Point(width - 1, 5));
            list.Add(new Point(width - 0, 5));
            //右下
            list.Add(new Point(width - 0, height - 5));
            list.Add(new Point(width - 1, height - 5));
            list.Add(new Point(width - 1, height - 3));
            list.Add(new Point(width - 2, height - 3));
            list.Add(new Point(width - 2, height - 2));
            list.Add(new Point(width - 3, height - 2));
            list.Add(new Point(width - 3, height - 1));
            list.Add(new Point(width - 5, height - 1));
            list.Add(new Point(width - 5, height - 0));
            //左下
            list.Add(new Point(5, height - 0));
            list.Add(new Point(5, height - 1));
            list.Add(new Point(3, height - 1));
            list.Add(new Point(3, height - 2));
            list.Add(new Point(2, height - 2));
            list.Add(new Point(2, height - 3));
            list.Add(new Point(1, height - 3));
            list.Add(new Point(1, height - 5));
            list.Add(new Point(0, height - 5));

            Point[] points = list.ToArray();

            GraphicsPath shape = new GraphicsPath();
            shape.AddPolygon(points);

            //将窗体的显示区域设为GraphicsPath的实例
            form.Region = new System.Drawing.Region(shape);
        }
    }
}
