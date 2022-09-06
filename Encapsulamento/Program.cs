namespace Encapsulamento
{
    internal class Program
    {
        /*É um princípio que consiste em esconder detalhes de implementação de um componente,  expondo apenas operações seguras e 
         * que o mantenha em um estado consistente. 
         * Regra de ouro: o objeto deve sempre estar em um estado consistente, e a própria classe deve garantir isso. 
         */
        static void Main(string[] args)
        {
            EncapsulamentoOpcaoUm p = new EncapsulamentoOpcaoUm("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome()); 
        }
    }
}