namespace ModificadorParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TESTANDO MÉTODO SUM COM PARAMS*/
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(4, 6, 5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            /*TESTANDO MÉTODO TRIPLEREF COM REF*/
            int a = 10;
            Calculator.TripleRef(ref a); // tbm é necessário atribuir o arg ref na chamada do método
            Console.WriteLine(a);


            /*TESTANDO MÉTODO TRIPLEOUT COM OUT*/
            int b = 5;
            int triplo;
            Calculator.TripleOut(b, out triplo);
            Console.WriteLine(triplo);

        }
    }
}