using System.Windows;

namespace LabApp
{
    public class Ellipse : CentrifiedFigure
    {
        public double SemiaxisX { get; set; }

        public double SemiaxisY { get; set; }


        public Ellipse(Point center, double semiaxisX, double semiaxisY)
            : base(center)
        {
            SemiaxisX = semiaxisX;
            SemiaxisY = semiaxisY;
        }
    }
}
