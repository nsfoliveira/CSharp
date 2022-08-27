namespace ConversorDeMoeda
{
    class ConversorDeMoeda
    {

        //atributo da classe
        public static double Iof = 6.0;

        //método estático da classe
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}