using System;

namespace Ex_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il numero 1:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il numero 2:");
            int j = int.Parse(Console.ReadLine());
            int somma = i + j;
            Console.WriteLine($"{i}+{j}={somma}");
        }
    }
}
