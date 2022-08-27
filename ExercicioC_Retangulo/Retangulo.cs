using System;
namespace ExercicioC_Retangulo
{
    class Retangulo
    {
        //atributos da classe
        public double Largura;
        public double Altura;
        
        //método da classe - cálculo da área
        public double Area()
        {
            return Largura * Altura; //o retorno da classe já é o cálculo da área
        }

        //método da classe - cálculo do perímetro
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        //método da classe - cálculo da diagonal
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}