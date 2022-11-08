using System.Globalization;

namespace ExercicioFixacaoLista
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }
        
        /*Método para cadastrar  o funcionário*/
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        /*Mpetodo para alterar o salário*/
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}