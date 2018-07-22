using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado: Rectangulo
    {
        private double m_lado1;
        private double m_lado2;

        public double Lado1
        {
          set { m_lado1 = value; }
          get { return m_lado1; }  

        }

        public double Lado2
        {

            set { m_lado2 = value; }
            get { return m_lado2; }

        }
    }
}