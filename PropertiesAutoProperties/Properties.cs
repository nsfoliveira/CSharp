using System.Globalization;
namespace PropertiesAutoProperties
{
    class Produto
    {

        /*atalho prop tab tab e ele monta a estrutura*/
        private string _nome;
        private double _preco; /*com autoproperties seria public double Preco {get; private set; } e com isso não há necessidade de implementar a property*/
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        /*Implementação da PROPERTIES*/
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque
        {
            get { return _preco * _quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

