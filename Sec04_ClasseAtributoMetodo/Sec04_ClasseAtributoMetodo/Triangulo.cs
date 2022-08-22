namespace Sec04_ClasseAtributoMetodo
{
    class Triangulo {
        //o public sinaliza que essas variáveis poderão ser acessadas em outro arquivo
        public double A;
        public double B;    
        public double C; 

        //atribuindo um método (função dentro de uma classe) para cálculo 
        public double CalculoArea()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
