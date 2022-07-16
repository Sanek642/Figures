using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Сircle : IFigures

    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set {
                if (radius < 0)
                    throw new ArgumentOutOfRangeException("Радиус должен быть больше нуля!!!");
                radius = value;
            }
        }

        public double Area { get; set; }
        public Сircle() { }
        public Сircle(double radius) 
        { 
            Radius = radius; 
            Area = Math.PI * Math.Pow(radius, 2);
        }
     
    }
}
