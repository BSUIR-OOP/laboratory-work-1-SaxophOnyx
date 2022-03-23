using System.Windows.Media;

namespace LabApp
{
    public abstract class ConnectedFigure: AbstractFigure
    {
        public Color FillingColor { get; set; }


        public ConnectedFigure()
            : base()
        {
            FillingColor = Color.FromRgb(0, 0, 0);
        }
    }
}
