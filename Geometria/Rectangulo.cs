using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo: Poligono
    {
        private double m_base;
        private double m_altura;

        public double Base
        {
           set { m_base = value; }
           get { return m_base; }
        }

        public double Altura
        {
            set { m_altura = value; }
            get { return m_altura; }
        }
    }
}