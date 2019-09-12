/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 3: esercizio 3
 */

using System;

namespace Ex_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero = 123.456f;
            Console.WriteLine($"valuta {numero:c2}");
            Console.WriteLine($"due cifre decimali {numero:n2}");
            Console.WriteLine($"intero {numero:n0}");
            Console.WriteLine("percent: {0:P1}", numero/100);
        }
    }
}
