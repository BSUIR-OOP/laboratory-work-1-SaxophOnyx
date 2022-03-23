using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;

namespace LabApp
{
    public class FiguresConverter : IValueConverter
    {
        public FiguresConverter()
        {

        }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<System.Windows.Shapes.Shape> res = new ObservableCollection<System.Windows.Shapes.Shape>();

            foreach (ICanvasDisplayable figure in (value as ObservableCollection<ICanvasDisplayable>))
                res.Add(figure.CreateShape());

            return res;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
