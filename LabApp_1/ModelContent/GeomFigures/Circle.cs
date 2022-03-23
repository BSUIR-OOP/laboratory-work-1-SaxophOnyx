using System.Windows;

namespace LabApp
{
    public class Circle : CentrifiedFigure
    {
        public double Radius { get; set; }


        public Circle(Point center, double radius)
            : base(center)
        {
            Radius = radius;
        }
    }
}
