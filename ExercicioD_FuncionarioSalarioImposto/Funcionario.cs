using System.Globalization;
namespace ExercicioD_FuncionarioSalarioImposto
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //método para cálculo do salário líquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        //método para cálculo do salário com aumento
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        //método de sobreposição 
        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}