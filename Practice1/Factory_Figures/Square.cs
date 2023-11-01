using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory_Figures
{
    public class Square : IFigure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Square(double squareBase, double height)
        {
            Base = squareBase;
            Height = height;
        }
        public double CalculateArea()
        {
            return Base * Height;
        }
    }
}
