using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUBOvolum
{
    internal class VolCub
    {
        public double Lado { get; set; }

        // Constructor
        public VolCub(double lado)
        {
            Lado = lado;
        }

        // Método para calcular el volumen del cubo
        public double CalcularVolumen()
        {
            // El volumen de un cubo es igual al lado elevado al cubo
            return Math.Pow(Lado, 3);
        }
    }
}
