using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO CONTA NO INICIO PARA PODER SER UTILIZADA NO PROGRAMA (POIS SE FOSSE DECLARADA APENAS NO MOMENTO DO IF, ELE SÓ 'EXISTIRIA' DENTRO DO BLOCO DO IF)
            ContaBancaria conta;


            // COLHENDO DADOS DE ENTRADA E ATRIBUINDO A VARIÁVEIS TEMPORÁRIAS 
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            // IF PARA VERIFICAR RESPOSTA DO USUÁRIO
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // INSTANCIANDO A CONTA CASO ELA TENHA SALDO INICIAL COM O CONSTRUTOR DE 3 ARGUMENTOS
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                // INSTANCIANDO A CONTA CASO ELA NÃO TENHA SALDO INICIA, COM O CONSTRUTOR DE 2 ARGUMENTOS
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //CHAMANDO O MÉTODO DEPOSITO
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //CHAMANDO O MÉTODO PARA SAQUE
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}