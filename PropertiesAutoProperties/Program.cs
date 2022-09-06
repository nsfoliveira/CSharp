namespace PropertiesAutoProperties
{
    internal class Program
    {
        /*São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos 
         
         Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. 
        As propriedades podem ser usadas como se fossem atributos públicos, mas na verdade elas são métodos especiais chamados "acessadores". 
        Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos métodos.
        
        Propriedades Autoimplementadas
        É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operações gete set. 

        public double Preco { get; private set; }

         
         */

        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);

        }
    }
}