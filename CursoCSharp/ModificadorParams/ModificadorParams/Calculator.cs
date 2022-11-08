using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams
{
    class Calculator
    {
        /// <summary>
        /// Método para calcular a soma de uma quantidade variável de valores
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Sum(params int[] numbers) // o arg params avisa o compilador que queremos uma função que possa receber uma quantia variável de valores
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        /// <summary>
        /// Método para cálcular o triplo de um determinado valor que é atribuido a uma variável
        /// </summary>
        /// /// <param modificador="ref"></param>
        /// <param name="x"></param> 
        public static void TripleRef(ref int x)
        {
            x *= 3;
        }

        /// <summary>
        ///Método para calcular o triplo de uma determinada variável, mas atribuído a uma outra variável de saída que não precisará ser iniciada
        /// </summary>
        public static void TripleOut(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}