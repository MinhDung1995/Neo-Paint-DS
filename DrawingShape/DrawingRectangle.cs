using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace NeoDrawable
{
    class DrawingRectangle : Drawing
    {
        public override void Draw(Canvas canvas, DrawableObject obj)
        {
            List<Point2D> points = ((DrawableRectangle)obj)
                .Draw(obj.StartPoint.X, obj.StartPoint.Y, obj.EndPoint.X, obj.EndPoint.Y);

            canvas.Children.Add(PolygonFromPoints(points));
        }

        public override string ToString()
        {
            return "Drawing Rectangle";
        }
    }
}
