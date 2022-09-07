using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuMiniProjeto_ContratacaoServico
{
    internal class RegraDeNegocio
    {
        //Declarando os atributos de Aluguél e Taxa
        //nessa solução não será disponibilizado alteração dos valores, portanto set estará privado
        public double AluguelUm{get; private set;}
        public double AluguelDois { get; private set; }
        public double TaxaUm { get; private set; }
        public double TaxaDois { get; private set; }
        public double TaxaTrês   { get; private set; }


    }
}
