using System;
using System.Globalization;

namespace ExercicioA_NomeIdade {
    class AplicacaoNomeIdade
    {
        static void Main(string[] args)
        {

            //instanciando e declarando
            PessoaNomeIdade p1 = new PessoaNomeIdade();
            PessoaNomeIdade p2 = new PessoaNomeIdade();

            //entrada dos dados
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1._nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1._idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2._nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2._idade = int.Parse(Console.ReadLine());

            //verificando a idade da pessoa mais velha
            if (p1._idade > p2._idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1._nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2._nome);
            }
        }
    }
}