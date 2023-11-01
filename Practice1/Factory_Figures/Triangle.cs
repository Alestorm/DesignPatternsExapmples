using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory_Figures
{
    public class Triangle : IFigure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double triangleBase, double height)
        {
            Base = triangleBase;

            Height = height;

        }
        public double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}
