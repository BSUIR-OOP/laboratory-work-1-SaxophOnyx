using System.Windows;

namespace LabApp
{
    class LineSegment: AbstractFigure
    {
        public Point A { get; set; }

        public Point B { get; set; }


        public LineSegment(Point a, Point b)
            : base()
        {
            A = a;
            B = b;
        }


        public override int GetID()
        {
            return FigureIDs._lineSegmentID;
        }
    }
}
