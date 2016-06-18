using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public abstract class DrawableText : DrawableObject, TextBrushChangable, TextStyleChangable, TextFontChangable, TextSizeChangable
    {
        private int _text;
        private Brush _textBrush;
        private Double _textSize;
        private int _textFont;
        private int _textStyles;

        public int Content
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int TextBrush
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int TextSize
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TextStyles TextStyles
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TextFont TextFont
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void ChangeTextBrush()
        {
            throw new NotImplementedException();
        }

        public void ChangeStyle()
        {
            throw new NotImplementedException();
        }

        public void ChangeTextFont()
        {
            throw new NotImplementedException();
        }

        public void ChangeTextSize()
        {
            throw new NotImplementedException();
        }
    }
}
