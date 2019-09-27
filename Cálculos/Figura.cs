using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculos
{
    public class Figura
    {
        private string nombre;
        private double ladoA;
        private double ladoB;

        public string Nombre { get { return nombre; } set {nombre = value; } }
        public double LadoA { get { return ladoA; } set { ladoA = value; } }
        public double LadoB { get {return ladoB; } set {ladoB = value; } }
    }
}
