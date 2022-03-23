using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LabApp
{
    public sealed class DisplayableRectangle : Rectangle, ICanvasDisplayable
    {
        public DisplayableRectangle(Point center, double width, double height)
            : base(center, width, height)
        {

        }


        Shape ICanvasDisplayable.CreateShape()
        {
            System.Windows.Shapes.Rectangle shape = new System.Windows.Shapes.Rectangle
            {
                Height = Height,
                Width = Width,
                Margin = new Thickness(CenterPos.X - Width / 2, CenterPos.Y - Height / 2, 0, 0),
                Stroke = new SolidColorBrush(OutlineColor),
                StrokeThickness = OutlineThickness,
                Fill = new SolidColorBrush(FillingColor)
            };

            return shape;
        }
    }
}
