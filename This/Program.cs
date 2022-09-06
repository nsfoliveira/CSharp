namespace This
{
    internal class Program
    {
        /*É uma referência para o próprio objeto 
         * Usos comuns: 
         * Diferenciar atributos de variáveis locais (Java) 
         *  EXEMPLO: 
         *  public Produto(string Nome, double Preco) { 
         *      this.Nome = Nome; 
         *      this.Preco = Preco; 
         *      Quantidade = 0; 
         * 
         * Referenciar outro construtor em um construtor 
         *  EXEMPLO:
         * public Produto() { 
         *      Quantidade = 0; 
         *      }
         * public Produto(string nome, double preco) : this() { - Ele vai reaproveitar o construtor anterior para não termos que repedir o Quantidade = 
         *      Nome = nome; 
         *      Preco = preco; 
         *      } 
         *public Produto(string nome, double preco, int quantidade) : this(nome, preco) { 
         *      *Quantidade = quantidade; 
         *      }
         *
         *Passar o próprio objeto como argumento na chamada de um método ou construtor
         *class ChessMatch { 
         *      (...) 
         *      PlaceNewPiece('e', 1, new King(board, Color.White, this)); 
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}