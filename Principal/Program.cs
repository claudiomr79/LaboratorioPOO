using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo  circulo1 = new Circulo();
            circulo1.Radio = 10;
            Console.WriteLine("El perimetro de un circulo de radio 10 es: {0}", circulo1.CalcularPerimetro());
            Console.WriteLine("La superficie  de un circulo de radio 10 es: {0}", circulo1.CalcularSuperficie());
            Console.ReadKey();

            Triangulo triangulo1 = new Triangulo();
            triangulo1.Base = 2;
            triangulo1.Altura = 10;
            Console.WriteLine("El perimetro de un triangulo de base 2 y altura 10 es: {0}", triangulo1.CalcularPerimetro());
            Console.WriteLine("La superficie  de un triangulo de base 2 y altura 10 es: {0}", triangulo1.CalcularSuperficie());
            Console.ReadKey();

            Rectangulo rect = new Rectangulo();
            rect.Altura = 10;
            rect.Base = 5;
            Console.WriteLine("El perimetro de un rectangulo de base 5 y altura 10 es: {0}", rect.CalcularPerimetro(5,10));
            Console.WriteLine("La superficie  de un rectangulo de base 5 y altura 10 es: {0}", rect.CalcularSuperficie(5,10));
            Console.ReadKey();

            Cuadrado  cuad = new Cuadrado ();
            cuad.Lado = 10;
            Console.WriteLine("El perimetro de un cuadrado de lado 10 es: {0}", cuad.CalcularPerimetro(10 , 10));
            Console.WriteLine("La superficie  de un cuadrado de lado 10 es: {0}", cuad.CalcularSuperficie(10 , 10));
            Console.ReadKey();

        }
    }
}
