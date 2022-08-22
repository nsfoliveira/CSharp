using System;
using System.Globalization;


namespace Sec04_ClasseAtributoMetodo {
    class AplicacaoTriangulo {
        static void Main(string[] args) {
            // utilizamos o new quando trabalhamos com classe instanciando, que é uma alocação dinamica de memoria

            Triangulo x, y; //declarando

            x = new Triangulo(); //instanciando
            y = new Triangulo();

            Console.WriteLine("Entra com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entra com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p;
            double areaX = x.CalculoArea();
            double areaY = y.CalculoArea();

            

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
         }
    }
}