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


        }
    }
}