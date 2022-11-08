namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointStruct p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p); //mostrará na tela os valores declarados

            p = new PointStruct();
            Console.WriteLine(p);//ele recria as caixinhas vazias 


            // Para atribuir valor null em um struct (se tentar double x = null; o c# não permitirá)
            Nullable<double> x = null; // ou double? x = null
            Console.WriteLine(x.GetValueOrDefault()); //nesse caso o valor default de double em caso nulo é 0
            Console.WriteLine(x.HasValue); //ele verificará se na variável ha ou não um valor
            //Console.WriteLine(x.Value); //ela lança uma exceção, para usá-la tenho que ter um IF

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("x is null");

            double y = x ?? 3.0;// ?? fara com que se a variável tiver valor nulo, então ele atribui um valor
            Console.WriteLine(y);   
        }
    }
}