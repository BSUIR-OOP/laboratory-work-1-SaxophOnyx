using System.Windows;
using System.Windows.Media;

namespace LabApp
{
    public class Polygon : ConnectedFigure
    {
        public PointCollection Points { get; set; }


        public Polygon(params Point[] points)
        {
            Points = new PointCollection(points);
        }
    }
}
