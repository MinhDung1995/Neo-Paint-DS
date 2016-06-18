using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public interface Drawable
    {
        List<Point2D> Draw(int startX, int startY, int endX, int endY);
    }
}
