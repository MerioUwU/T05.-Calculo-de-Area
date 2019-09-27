using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculos
{
    public class Operación
    {
        public double Area(double LadoA)
        {
            double result = 0;
            result = LadoA * LadoA;
            return result;
        }
        public double Area(double LadoA, double LadoB)
        {
            double result = 0;
            result = LadoA * LadoB;
            return result;
        }
        public double Area(double a, double LadoA, double LadoB)
        {
            double result = 0;

            return result;
        }
    }
}
