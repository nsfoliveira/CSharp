using System;
using System.Globalization;

namespace point
{
    internal class Vetor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //perguntando quantos registros terá o vetor

            // criando variável que terá o vetor, para isso usamos []
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("A média é: ", avg.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
