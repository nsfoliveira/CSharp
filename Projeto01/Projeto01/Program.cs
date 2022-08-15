using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args) 
            /// é uma declaração padrão para identificar o ponto de entrada
        {
            sbyte n1 = 31;
            int n2 = 1000;
            long n3 = 2147483648L;
            /// é uma boa prática expliciar ao final do numero a letra L indicando que é long
            bool completo = false;
            char feminino = 'F';
            char unicode_letra = '\u0041';
            /// /u indica que estamos inserindo um unicode
            double n4 = 2260.5416;
            float n5 = 4.5f;
            string nome = "Natália Oliveira";
            object nome_obj = "Natália Oliveira";
            /// object é um tipo genérico 


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(completo);
            Console.WriteLine(feminino);
            Console.WriteLine(unicode_letra);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(nome_obj);
            Console.WriteLine(n4.ToString("F3", CultureInfo.InvariantCulture));
            /// placeholder
            Console.WriteLine("{0} tem {1} anos e recebe {2:F2} reais", nome, n1, n4);
            /// interpolação
            Console.WriteLine($"{nome} tem {n1} anos e recebe {n4:F2} reais");
            /// concatenação de string
            Console.WriteLine(nome + " tem " + n1 + " anos e recebe " + n4.ToString("F2") + " reais");

        }
    }
}