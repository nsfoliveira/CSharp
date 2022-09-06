using System.Globalization;

namespace Sobrecarga
{
    internal class Program
    {
        /*É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes listas de parâmetros. 
         PROPOSTA DE MELHORIA NO PROGRAMA CRIADO NO PROJETO CONSTRUTORES:
        Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto. A quantidade em estoque deste novo produto, 
        por padrão, deverá então ser iniciada com o valor zero. 

        Nota: é possível também incluir um construtor padrão(sem parâmetros)*/
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());


            /*Abaixo o construtor de 2 args, mas nada impede que usemos o construto com 3 argsm é só informar nos parametros*/
            ProdutoSobrecarga p = new ProdutoSobrecarga(nome, preco);

            /*Utilizando o construtor padrão onde não é obrigatório passar valores nos parametros */
            ProdutoSobrecarga p2 = new ProdutoSobrecarga();

            /*Uma sintaxe alternativa para inicializar valores é. Mesmo que a classe não tivesse construtores, 
             * essa é uma forma que funcionaria. Ela é possível devido ao construtor padrão*/
            ProdutoSobrecarga p3 = new ProdutoSobrecarga { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 10 
            };


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());


            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());


            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
