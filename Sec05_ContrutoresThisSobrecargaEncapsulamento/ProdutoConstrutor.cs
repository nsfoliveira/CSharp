using System.Globalization;

namespace Construtores
{
    class ProdutoConstrutor
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*gerando construtor que garantirá que ao instanciar os produto será obrigado a informar valores */
        public ProdutoConstrutor(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        } /*terá o mesmo nome da classe*/



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
