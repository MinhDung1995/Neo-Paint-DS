using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public interface Drawable
    {
        Object Draw(int startX, int startY, int endX, int endY);
    }
}
