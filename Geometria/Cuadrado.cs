using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado: Rectangulo
    {
        private double m_lado;
        

        public double Lado
        {
          set { m_lado = value; }
          get { return m_lado; }  

        }

    }
}