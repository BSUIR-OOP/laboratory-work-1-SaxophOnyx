using System.Windows.Media;

namespace LabApp
{
    public abstract class AbstractFigure
    {
        public Color OutlineColor { get; set; }

        public double OutlineThickness { get; set; }


        public AbstractFigure()
        {
            OutlineColor = Color.FromRgb(0, 0, 0);
            OutlineThickness = 1;
        }
    }
}
