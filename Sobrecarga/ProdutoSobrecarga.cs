using System.Globalization;

namespace   Sobrecarga
{
    class ProdutoSobrecarga
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*gerando sobrecarga, que também é um construtor padrão, onde não informaremos nenhum args*/
        public ProdutoSobrecarga()
        {
        }

        /*gerando construtor que garantirá que ao instanciar os produto será obrigado a informar valores */
        public ProdutoSobrecarga(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        } /*terá o mesmo nome da classe*/


        /*gerando sobrecarga, que também é um construtor com dois args*/
        public ProdutoSobrecarga(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;/*por padrão atributos numéricos já recebem valor 0, essa linha é dispensável, estamos informando para fins didáticos*/
        }

       
          
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
