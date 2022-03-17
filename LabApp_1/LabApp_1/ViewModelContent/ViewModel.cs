using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace LabApp
{
    class ViewModel : INotifyPropertyChanged
    {
        private SolidColorBrush _backgroundColor;
        public SolidColorBrush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                NotifyPropertyChanged(nameof(BackgroundColor));
            }
        }

        private FiguresObservableCollection _figures;
        public FiguresObservableCollection Figures
        {
            get { return _figures; }
            set
            {
                _figures = value;
                NotifyPropertyChanged(nameof(Figures));
            }
        }


        public ViewModel()
        {
            Figures = new FiguresObservableCollection();
            Figures.CollectionChanged += Figures_CollectionChanged;
            FillCollection();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Figures_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged(nameof(Figures));
        }

        private void FillCollection()
        {
            Dot dot = new Dot(70, 40);
            dot.OutlineThickness = 8;
            dot.OutlineColor = System.Windows.Media.Color.FromRgb(10, 120, 120);
            Figures.Add(dot);

            Rectangle rect = new Rectangle(new Point(70, 110), 80, 60);
            rect.FillingColor = System.Windows.Media.Color.FromRgb(255, 40, 40);
            rect.OutlineThickness = 2;
            Figures.Add(rect);

            Circle circle = new Circle(new Point(100, 250), 70);
            circle.OutlineColor = System.Windows.Media.Color.FromRgb(10, 240, 10);
            circle.OutlineThickness = 10;
            Figures.Add(circle);

            Polygon pol = new Polygon(new Point(145, 40), new Point(265, 50), new Point(285, 150), new Point(255, 200), new Point(155, 150));
            pol.FillingColor = System.Windows.Media.Color.FromRgb(255, 255, 10);
            pol.OutlineColor = System.Windows.Media.Color.FromRgb(10, 10, 240);
            Figures.Add(pol);

            LineSegment segm = new LineSegment(new Point(200, 320), new Point(380, 190));
            segm.OutlineThickness = 8;
            segm.OutlineColor = System.Windows.Media.Color.FromRgb(150, 20, 255);
            Figures.Add(segm);

            Ellipse ell = new Ellipse(new Point(410, 90), 100, 40);
            ell.FillingColor = System.Windows.Media.Color.FromRgb(230, 230, 230);
            Figures.Add(ell);

            RegularPolygon regPol = new RegularPolygon(new Point(520, 240), 8, 80);
            regPol.FillingColor = System.Windows.Media.Color.FromRgb(10, 255, 10);
            regPol.OutlineColor = System.Windows.Media.Color.FromRgb(10, 155, 10);
            regPol.OutlineThickness = 9;
            Figures.Add(regPol);
        }
    }
}

