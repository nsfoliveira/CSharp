using System.Globalization;

namespace ExercicioFixacao
{
    class ContaBancaria
    {
        // ATRIBUTOS DA CLASSE
        public int Numero { get; private set; } // incluído a palavra private, pois não poderemos realizar alteração na numeração
        public string Titular { get; set; } // poderá ser acessado e alterado
        public double Saldo { get; private set; } // poderá ser acessado, mas a alteração somente por meio de uma ação (depósito ou saque)


        // CONSTRUTOR DA CLASSE COM 2 ARGUMENTOS
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        // CONSTRUTOR DA CLASSE COM 3 ARGUMENTOS, UTILIZANDO THIS PARA REUTILIZAR OS ARGUMENTOS CRIADOS NO CONSTRUTOR ANTERIOR
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        // COSTRUTOR DA CLASSE PARA DEPOSITO, ONDE SERÁ SOMADO AO SALDO O NOVO VALOR DE ENTRADA
        public void Deposito(double quantia) // void pq ela não retornará nada, apenas irá no alterar o valor do atributo Saldo
        {
            Saldo += quantia;
        }


        // CONSTRUTOR DA CLASSE PARA SAQUE, ONDE É SUBTRAÍDO O VALOR DO SAQUE E O VALOR DA TAXA
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        // SAÍDA QUE MOSTRARÁ OS DADOS DA CONTA DEPOIS DE RECEBER AS ENTRADAS DE DADOS
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}