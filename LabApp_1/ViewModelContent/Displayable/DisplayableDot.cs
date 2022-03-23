using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LabApp
{
    public sealed class DisplayableDot : Dot, ICanvasDisplayable
    {
        public DisplayableDot(double x, double y)
            : base(x, y)
        {

        }


        Shape ICanvasDisplayable.CreateShape()
        {
            System.Windows.Shapes.Ellipse shape = new System.Windows.Shapes.Ellipse
            {
                Width = OutlineThickness,
                Height = OutlineThickness,
                Margin = new Thickness(X - OutlineThickness / 2, Y - OutlineThickness / 2, 0, 0),
                Stroke = new SolidColorBrush(OutlineColor),
                StrokeThickness = 0,
                Fill = new SolidColorBrush(OutlineColor)
            };

            return shape;
        }
    }
}
