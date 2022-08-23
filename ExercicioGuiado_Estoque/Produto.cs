using System.Globalization;

namespace ExercicioGuiado_Estoque
{
    internal class Produto
    {
        //atributos da classe
        public string Nome;
        public double Preco;
        public int Quantidade;

        //operação: total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //utilizando void para método que atualiza quantidade de itens que entraram
        public void AtualizaProdutos(int quantidade)
        {
            Quantidade += quantidade;    
        }

        //utilizando void para método que atualiza quantidade de itens que sairam
        public void RemoveProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //fazendo sobreposição
        //override indica que essa operação veio de outra classe
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
