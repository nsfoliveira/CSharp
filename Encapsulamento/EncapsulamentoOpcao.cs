using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
         /* Opção 1: implementação manual 
         * • Todo atributo é definido como private 
         * • Implementa-se métodos Gete Set para cada atributo, conforme regras de negócio 
         * • Nota: não é usual na plataforma C#*/

    internal class EncapsulamentoOpcaoUm
    {
        /*Declarando os atributos como private, isso impedirá que seja acessado em outra class*/
        private string _nome;
        private double _preco;
        private int _quantidade;

        public EncapsulamentoOpcaoUm()
        {
        }

        public EncapsulamentoOpcaoUm(string nome, double preco, int quantidade)
        {
            _nome = _nome;
            _preco = _preco;
            _quantidade = _quantidade;
        }

        /*implementand método get para obter o valor do objeto*/
        public string GetNome()
        {
            return _nome;   
        }

        /*implementando o método set para alterar o objeto do método*/
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 0) { 
                _nome = nome; 
            }            
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;   
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
                + ", " + _quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
