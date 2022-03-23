using System.Windows;

namespace LabApp
{
    public class RegularPolygon : CentrifiedFigure
    {
        public int SidesCount { get; set; }

        public double SideLength { get; set; }


        public RegularPolygon(Point center, int sidesCount, double sideLength)
            : base(center)
        {
            SidesCount = sidesCount;
            SideLength = sideLength;
        }
    }
}
