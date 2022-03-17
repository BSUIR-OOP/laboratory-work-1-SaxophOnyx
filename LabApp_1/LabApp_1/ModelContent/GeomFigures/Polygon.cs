using System.Windows;

namespace LabApp
{
    class Polygon: ConnectedFigure
    {
        public Point[] Points { get; set; }


        public Polygon(params Point[] points)
        {
            Points = new Point[points.Length];
            points.CopyTo(Points, 0);
        }


        public override int GetID()
        {
            return FigureIDs._polygonID;
        }
    }
}
