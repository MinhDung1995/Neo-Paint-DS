using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace NeoDrawable
{
    class DrawingCircle : Drawing
    {
        public void Draw(Canvas canvas, DrawableObject obj)
        {
            List<Point2D> points = ((DrawableCircle)obj)
                .Draw(obj.StartPoint.X, obj.StartPoint.Y, obj.EndPoint.X, obj.EndPoint.Y);

            Ellipse e = new Ellipse { Width = points[1].X, Height = points[1].Y };
            e.Margin = new System.Windows.Thickness(points[0].X - points[1].X / 2, points[0].Y - points[1].Y / 2, 0, 0);

            canvas.Children.Add(e);
        }
    }
}
