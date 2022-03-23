using System.Windows;

namespace LabApp
{
    public abstract class CentrifiedFigure : ConnectedFigure
    {
        public Point CenterPos { get; set; }


        public CentrifiedFigure(Point center)
            : base()
        {
            CenterPos = center;
        }
    }
}
