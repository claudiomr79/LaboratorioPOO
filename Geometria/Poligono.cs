using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Poligono
    {

        public double CalcularPerimetro(double lado1 , double lado2)
        {
            return (lado1 + lado2) * 2;
        }

        public double CalcularSuperficie(double lado1, double lado2)
        {
            return lado1 * lado2;
        }
    }
}