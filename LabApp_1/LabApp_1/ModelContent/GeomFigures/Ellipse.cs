namespace LabApp
{
    class Ellipse: CentrifiedFigure
    {
        public double SemiaxisX { get; set; }

        public double SemiaxisY { get; set; }


        public Ellipse(System.Windows.Point center, double semiaxisX, double semiaxisY)
            : base(center)
        {
            SemiaxisX = semiaxisX;
            SemiaxisY = semiaxisY;
        }


        public override int GetID()
        {
            return FigureIDs._ellipseID;
        }
    }
}
