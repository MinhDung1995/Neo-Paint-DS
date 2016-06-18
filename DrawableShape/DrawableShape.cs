using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public abstract class DrawableShape : DrawableObject
    {
        // Kiểu đối tượng vẽ
        public override string GetDrawableType()
        {
            return "Drawable Shape";
        }
    }
}
