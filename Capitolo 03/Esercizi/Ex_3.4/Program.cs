/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 3: esercizio 4
 */


using System;

namespace Ex_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Ciao {nome}, premi un tasto per uscire.");
            Console.ReadKey();
        }
    }
}
