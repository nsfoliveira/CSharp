using System;
using System.Globalization;


namespace ExercicioGuiado_Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando e instanciando
            Produto p = new Produto();

            //entrada dos dados
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            //saida dados do produto
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            //novas quantidades adicionadas ao estoque
            Console.Write("Digite a quantidade de produtos a ser adicionada:  ");
            int qtd = int.Parse(Console.ReadLine());
            p.AtualizaProdutos(qtd);
            Console.WriteLine("Dados do atualizados: " + p);

            //quantidades removidas ao estoque
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removida:  ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoveProduto(qtd);
            Console.WriteLine("Dados do atualizados: " + p);


        }
    }
}