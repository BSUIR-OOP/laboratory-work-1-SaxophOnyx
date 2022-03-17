﻿using System.Windows;

namespace LabApp
{
    class Rectangle: CentrifiedFigure
    {
        public double Width { get; set; }

        public double Height { get; set; }


        public Rectangle(Point center, double width, double height)
            :base(center)
        {
            Width = width;
            Height = height;
        }


        public override int GetID()
        {
            return FigureIDs._rectangleID;
        }
    }
}
