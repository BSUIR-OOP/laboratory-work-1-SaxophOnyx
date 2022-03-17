namespace LabApp
{
    class Dot: AbstractFigure
    {
        public double X { get; set; }

        public double Y { get; set; }


        public Dot(double x, double y)
            : base()
        {
            X = x;
            Y = y;
        }


        public override int GetID()
        {
            return FigureIDs._dotID;
        }
    }
}
