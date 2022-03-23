using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LabApp
{
    public sealed class DisplayableEllipse : Ellipse, ICanvasDisplayable
    {
        public DisplayableEllipse(Point center, double semiaxisX, double semiaxisY)
            : base(center, semiaxisX, semiaxisY)
        {

        }


        Shape ICanvasDisplayable.CreateShape()
        {
            System.Windows.Shapes.Ellipse shape = new System.Windows.Shapes.Ellipse
            {
                Width = SemiaxisX * 2,
                Height = SemiaxisY * 2,
                Margin = new Thickness(CenterPos.X - SemiaxisX, CenterPos.Y - SemiaxisY, 0, 0),
                Stroke = new SolidColorBrush(OutlineColor),
                StrokeThickness = OutlineThickness,
                Fill = new SolidColorBrush(FillingColor)
            };

            return shape;
        }
    }
}
