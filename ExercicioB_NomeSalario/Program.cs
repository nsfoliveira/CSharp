using System.Globalization;

namespace ExercicioB_NomeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando e instanciando
            FuncionarioNomeSalario f1 = new FuncionarioNomeSalario();
            FuncionarioNomeSalario f2 = new FuncionarioNomeSalario();


            //entrada dos dados
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1._nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1._salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2._nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2._salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculando a média dos salarios
            double media = (f1._salario + f2._salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}