using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LabApp
{
    public sealed class DisplayablePolygon : Polygon, ICanvasDisplayable
    {
        public DisplayablePolygon(params Point[] points)
            : base(points)
        {

        }


        Shape ICanvasDisplayable.CreateShape()
        {
            System.Windows.Shapes.Polygon shape = new System.Windows.Shapes.Polygon();

            foreach (Point p in Points)
                shape.Points.Add(p);

            shape.Margin = new Thickness(0, 0, 0, 0);
            shape.Stroke = new SolidColorBrush(OutlineColor);
            shape.StrokeThickness = OutlineThickness;
            shape.Fill = new SolidColorBrush(FillingColor);

            return shape;
        }
    }
}
