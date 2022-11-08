/*Laço for each
Sintaxe opcional e simplificada para percorrer coleções
Leitura: "para cada objeto 'obj' contido em vect, faça:"*/

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            /*Usando for each*/
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

            /*Usando o For*/
            for(int i=0; i<vect.Length; i++)
            {
                Console.WriteLine(vect[i]); 
            }

        }
    }
}