using System;
using System.Globalization;

namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m= int.Parse(Console.ReadLine()); //perguntando quantos registros terá o vetor

            //como usaremos o método da classe, vamos instancia-la, mas com os colchetes de vetor
            Produto[] vect2 = new Produto[m];

            // como ele é um vetor do tipo CLASSE e não do tipo STRUCT, teremos tbm que instanciar cada item/objeto
            for (int i = 0; i < m; i++)
            {
                //criamos as variáveis temporárias para receber os valores
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //instanciando os itens
                vect2[m] = new Produto { Name = name, Proce = price };
            }
            double sum = 0.0;
            for (int i = 0; i < m; i++)
            {
                sum = sum + vect2[i].Proce;
            }

            double avg = sum / m;

            Console.WriteLine("A média é: " + avg.ToString("F2", CultureInfo.InvariantCulture)); 

        }
    }
}