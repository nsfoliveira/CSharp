using System;
using System.Globalization;
using System.Net;

namespace Construtores
{
    class Program
    {

        /* É uma operação especial da classe, que executa no momento da instanciação do objeto 
         * Usos comuns: 
         * Iniciar valores dos atributos 
         * Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação(injeção de dependência)
         * Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão: 
         * Produto p = new Produto(); 
         * É possível especificar mais de um construtor na mesma classe(sobrecarga)*/


        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());


            /*Acima informamos os dados de entrada que utilizaremos no construtor, assim instanciamos o produto com os dados de entrada*/
            ProdutoConstrutor p = new ProdutoConstrutor(nome, preco, quantidade);


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

