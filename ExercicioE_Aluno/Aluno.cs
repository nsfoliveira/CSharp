
namespace ExercicioE_Aluno
{
    class Aluno
    {
        //atributos da classe
        public string Nome;
        public double Nota1, Nota2, Nota3;

        //método para cálculo da nota final
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        //método para verificação de aprovação 
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //método para trazer quantidade de pontos que faltaram para aprovação
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}