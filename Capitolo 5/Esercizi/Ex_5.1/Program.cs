using System;

namespace Ex_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci numero 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci numero 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {(double)a / b}");
        }
    }
}
