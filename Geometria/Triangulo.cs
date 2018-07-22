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

        public double CalcularPerimetro()
        {
            double hip = Math.Sqrt (Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            return hip + Base + Altura;
        }

        public double CalcularSuperficie()
        {
            return (Base * Altura) / 2; 
        }
    }
}