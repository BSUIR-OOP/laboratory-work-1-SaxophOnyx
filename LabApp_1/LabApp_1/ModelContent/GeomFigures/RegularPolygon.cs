using System.Windows;

namespace LabApp
{
    class RegularPolygon: CentrifiedFigure
    {
        public int SidesCount { get; set; }

        public double SideLength { get; set; }


        public RegularPolygon(Point center, int sidesCount, double sideLength)
            : base(center)
        {
            SidesCount = sidesCount;
            SideLength = sideLength;
        }


        public override int GetID()
        {
            return FigureIDs._regularPolygonID;
        }
    }
}
