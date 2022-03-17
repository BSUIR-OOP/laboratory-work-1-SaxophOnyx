using System.Windows;

namespace LabApp
{
    class Circle: CentrifiedFigure
    {
        public double Radius { get; set; }


        public Circle(Point center, double radius)
            : base(center)
        {
            Radius = radius;
        }


        public override int GetID()
        {
            return FigureIDs._circleID;
        }
    }
}
