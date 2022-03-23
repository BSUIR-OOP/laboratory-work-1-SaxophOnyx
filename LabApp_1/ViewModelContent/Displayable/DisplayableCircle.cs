using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LabApp
{
    public sealed class DisplayableCircle: Circle, ICanvasDisplayable
    {
        public DisplayableCircle(Point center, double radius)
            : base(center, radius)
        {

        }


        Shape ICanvasDisplayable.CreateShape()
        {
            System.Windows.Shapes.Ellipse shape = new System.Windows.Shapes.Ellipse
            {
                Width = Radius * 2,
                Height = Radius * 2,
                Margin = new Thickness(CenterPos.X - Radius, CenterPos.Y - Radius, 0, 0),
                Stroke = new SolidColorBrush(OutlineColor),
                StrokeThickness = OutlineThickness,
                Fill = new SolidColorBrush(FillingColor)
            };

            return shape;
        }
    }
}
