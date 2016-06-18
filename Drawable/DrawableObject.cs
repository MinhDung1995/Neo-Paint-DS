using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public abstract class DrawableObject : Drawable, Clonable, BorderBrushChangable, 
        BorderThicknessChangable, BorderStyleChangable, BackgroundBrushChangable
    {
        protected Point2D _startPoint;
        protected Point2D _endPoint;
        protected Brush _backgroundBrush;
        protected Border _border;

        public Brush BackgroundBrush
        {
            get
            {
                return _backgroundBrush;
            }
            set
            {
                _backgroundBrush = value;
            }
        }
        public Border Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }
        public Point2D StartPoint
        {
            get
            {
                return _startPoint;
            }
        }
        public Point2D EndPoint
        {
            get
            {
                return _endPoint;
            }
        }

        // Hàm nhận vào 2 điểm: trái trên và phải dưới
        // Trả về danh sách các điểm của hình được vẽ.
        public abstract List<Point2D> Draw(double startX, double startY, double endX, double endY);

        // Trả về bản sao tuyệt đối (Vị trí, tính chất,..)
        public abstract Clonable Clone();

        // Trả về bản sao tương đối, không bao gồm vị trí và kích thước
        // Sao chép các thuộc tính như độ dày border, nền 
        public abstract Clonable GetOriginalInstance();

        // Thay đổi màu border
        public virtual void ChangeBorderBrush(Brush newBrush)
        {
            _border.Brush = newBrush;
        }

        // Thay đổi độ dày border
        public virtual void ChangeBorderThickness(double thickness)
        {
            if (thickness >= 0)
                _border.Thickness = thickness;
        }

        // Thay đổi kiểu border
        public virtual void ChangeBorderStyle(BorderStyle style)
        {
                _border.Style = style;
        }

        // Thay đổi màu nền 
        public virtual void ChangeBackgroundBrush(Brush newBrush)
        {
            _backgroundBrush = newBrush;
        }

        // Kiểu đối tượng vẽ
        public abstract string GetDrawableType(); 
    }
}
