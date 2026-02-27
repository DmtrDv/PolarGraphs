using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarGraphsLib
{
    public class Points
    {
        public double coordinateX { get; set; }
        public double coordinateY { get; set; }
        public Points(double coordinateX, double coordinateY) 
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }

    }
}
