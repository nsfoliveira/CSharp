using System.Windows.Markup;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instanciando uma matriz
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //retorna a quantidade de elementos da matriz
            Console.WriteLine(mat.Rank);//retorna a quantidade de linhas
            Console.WriteLine(mat.GetLength(0));//traz o tamanho da primeira dimensão da matriz, que é o número de linhas
            Console.WriteLine(mat.GetLength(1));//traz o tamanho da segunda dimensão da matriz, que é o número de colunas*/

            Console.WriteLine("digite o tamanho das linhas e colunas da matriz");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n]; //instanciando a matriz quadrada

            for (int i = 0; i < n; i++) //esse laço for percorrerá as LINHAS 
            {
                Console.WriteLine("digite o valor da linha");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) // esse laço for percorrerá as COLUNAS
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagnonal: ");
            for(int i = 0; i < n; i++) //esse laço for verificará o valores contidos na diagonal principal que percorre [0,0], [1,1] e [2,2]
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++) //esse laço irá contar a quantidade de valores negativos há na matriz
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("quantidade de negativos: "+ count);
        }
    }
}