using System;
using System.Globalization;
namespace ExercicioD_FuncionarioSalarioImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando e instanciando
            Funcionario func = new Funcionario();


            //entrada dos dados
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //primeiro extrato
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            //segunda entrada de dados
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);//utilizando método de aumento

            //segundo extrato
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}