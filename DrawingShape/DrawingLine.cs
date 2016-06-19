using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;

namespace NeoDrawable
{
    public class DrawingLine : Drawing
    {
        public void Draw(Canvas canvas, DrawableObject obj)
        {
            List<Point2D> points = ((DrawableLine)obj)
                .Draw(obj.StartPoint.X, obj.StartPoint.Y, obj.EndPoint.X, obj.EndPoint.Y);

            Polygon pg = new Polygon();
            foreach (Point2D p in points)
            {
                pg.Points.Add(new Point(p.X, p.Y));
            }
            canvas.Children.Add(pg);
        }
    }
}
