using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int m_base;
        private int m_altura;

        public int Base
        {
            set { m_base = value; }
            get { return m_base; }
        }

        public int Altura
        {
            set { m_altura = value; }
            get { return m_altura; }
        }

        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperficie()
        {
            throw new System.NotImplementedException();
        }
    }
}