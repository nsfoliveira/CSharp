using System;
using System.Globalization;

namespace ExercicioFixacao01
{
    class Exercicio01
    {
        private static void Main(string[] args)

        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'F';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            
            Console.Write($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondamento com três casas decimais: {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0} ", medida.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}