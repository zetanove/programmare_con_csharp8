using System;

namespace Ex_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci numero 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci numero 2:");
            int b = int.Parse(Console.ReadLine());

            var and = a & b;
            var or = a | b;
            string strAnd = Convert.ToString(and, 2);
            string strOr = Convert.ToString(or, 2);

            Console.WriteLine($"a & b = {strAnd}");
            Console.WriteLine($"a | b = {strOr}");
        }
    }
}
