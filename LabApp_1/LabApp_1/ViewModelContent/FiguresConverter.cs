using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LabApp
{
    class FiguresConverter : IValueConverter
    {
        public FiguresConverter()
        {

        }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<System.Windows.Shapes.Shape> res = new ObservableCollection<System.Windows.Shapes.Shape>();

            for (int i = 0; i < (value as FiguresObservableCollection).Count; ++i)
                res.Add(CreateCorrespondingShape((value as FiguresObservableCollection)[i]));

            return res;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static System.Windows.Shapes.Shape CreateCorrespondingShape(AbstractFigure figure)
        {
            int id = figure.GetID();
            System.Windows.Shapes.Shape shape = null;
            switch (id)
            {
                case FigureIDs._dotID:
                {
                    shape = CreateDot(figure as Dot);
                    break;
                }

                case FigureIDs._lineSegmentID:
                {
                    shape = CreateLineSegment(figure as LineSegment);
                    break;
                }

                case FigureIDs._circleID:
                {
                    shape = CreateCircle(figure as Circle);
                    break;
                }

                case FigureIDs._ellipseID:
                {
                    shape = CreateEllipse(figure as Ellipse);
                    break;
                }

                case FigureIDs._rectangleID:
                {
                    shape = CreateRectangle(figure as Rectangle);
                     break;
                }

                case FigureIDs._regularPolygonID:
                {
                    shape = CreateRegularPolygon(figure as RegularPolygon);
                    break;
                }

                case FigureIDs._polygonID:
                {
                    shape = CreatePolygon(figure as Polygon);
                    break;
                }

                default:
                {
                    throw new Exception("FiguresConverterError");
                }
            }

            return shape;
        }

        private static System.Windows.Shapes.Ellipse CreateDot(Dot dot)
        {
            System.Windows.Shapes.Ellipse d = new System.Windows.Shapes.Ellipse
            {
                Width = dot.OutlineThickness,
                Height = dot.OutlineThickness,
                Margin = new System.Windows.Thickness(dot.X - dot.OutlineThickness / 2, dot.Y - dot.OutlineThickness / 2, 0, 0),
                Stroke = new System.Windows.Media.SolidColorBrush(dot.OutlineColor),
                StrokeThickness = 0,
                Fill = new System.Windows.Media.SolidColorBrush(dot.OutlineColor)
            };

            return d;
        }

        private static System.Windows.Shapes.Line CreateLineSegment(LineSegment segment)
        {
            System.Windows.Shapes.Line line = new System.Windows.Shapes.Line
            {
                X1 = segment.A.X,
                Y1 = segment.A.Y,
                X2 = segment.B.X,
                Y2 = segment.B.Y,
                //Margin = new System.Windows.Thickness((segment.A.X + segment.B.X) / 2, (segment.A.Y + segment.B.Y) / 2, 0, 0),
                Margin = new System.Windows.Thickness(0, 0, 0, 0),
                Stroke = new System.Windows.Media.SolidColorBrush(segment.OutlineColor),
                StrokeThickness = segment.OutlineThickness,
                Fill = new System.Windows.Media.SolidColorBrush(segment.OutlineColor)
            };

            return line;
        }

        private static System.Windows.Shapes.Ellipse CreateCircle(Circle circle)
        {
            System.Windows.Shapes.Ellipse rnd = new System.Windows.Shapes.Ellipse
            {
                Width = circle.Radius * 2,
                Height = circle.Radius * 2,
                Margin = new System.Windows.Thickness(circle.CenterPos.X - circle.Radius, circle.CenterPos.Y - circle.Radius, 0, 0),
                Stroke = new System.Windows.Media.SolidColorBrush(circle.OutlineColor),
                StrokeThickness = circle.OutlineThickness,
                Fill = new System.Windows.Media.SolidColorBrush(circle.FillingColor)
            };

            return rnd;
        }

        private static System.Windows.Shapes.Ellipse CreateEllipse(Ellipse ellipse)
        {
            System.Windows.Shapes.Ellipse el = new System.Windows.Shapes.Ellipse
            {
                Width = ellipse.SemiaxisX * 2,
                Height = ellipse.SemiaxisY * 2,
                Margin = new System.Windows.Thickness(ellipse.CenterPos.X - ellipse.SemiaxisX, ellipse.CenterPos.Y - ellipse.SemiaxisY, 0, 0),
                Stroke = new System.Windows.Media.SolidColorBrush(ellipse.OutlineColor),
                StrokeThickness = ellipse.OutlineThickness,
                Fill = new System.Windows.Media.SolidColorBrush(ellipse.FillingColor)
            };

            return el;
        }

        private static System.Windows.Shapes.Rectangle CreateRectangle(Rectangle rectangle)
        {
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle
            {
                Height = rectangle.Height,
                Width = rectangle.Width,
                Margin = new System.Windows.Thickness(rectangle.CenterPos.X - rectangle.Width / 2, rectangle.CenterPos.Y - rectangle.Height / 2, 0, 0),
                Stroke = new System.Windows.Media.SolidColorBrush(rectangle.OutlineColor),
                StrokeThickness = rectangle.OutlineThickness,
                Fill = new System.Windows.Media.SolidColorBrush(rectangle.FillingColor)
            };

            return rect;
        }

        private static System.Windows.Shapes.Polygon CreateRegularPolygon(RegularPolygon polygon)
        {
            System.Windows.Shapes.Polygon pol = new System.Windows.Shapes.Polygon();

            int N = polygon.SidesCount;
            double L = polygon.SideLength;

            double rad = L / (2 * Math.Sin(Math.PI / N));
            for (int i = 0; i < N; ++i)
            {
                double x = rad * Math.Cos(Math.PI / N * (2 * i + 1));
                double y = rad * Math.Sin(Math.PI / N * (2 * i + 1));
                pol.Points.Add(new Point(x + polygon.CenterPos.X, y + polygon.CenterPos.Y));
            }

            pol.Margin = new System.Windows.Thickness(0, 0, 0, 0);
            pol.Stroke = new System.Windows.Media.SolidColorBrush(polygon.OutlineColor);
            pol.StrokeThickness = polygon.OutlineThickness;
            pol.Fill = new System.Windows.Media.SolidColorBrush(polygon.FillingColor);

            return pol;
        }

        private static System.Windows.Shapes.Polygon CreatePolygon(Polygon polygon)
        {
            System.Windows.Shapes.Polygon pol = new System.Windows.Shapes.Polygon();

            for (int i = 0; i < polygon.Points.Length; ++i)
                pol.Points.Add(polygon.Points[i]);

            pol.Margin = new System.Windows.Thickness(0, 0, 0, 0);
            pol.Stroke = new System.Windows.Media.SolidColorBrush(polygon.OutlineColor);
            pol.StrokeThickness = polygon.OutlineThickness;
            pol.Fill = new System.Windows.Media.SolidColorBrush(polygon.FillingColor);

            return pol;
        }
    }
}
