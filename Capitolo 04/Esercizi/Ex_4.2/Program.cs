/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4:
 * Esercizio 2) Scrivere un’applicazione Console che richieda all’utente l’inserimento di
 * due numeri e ne stampi somma e prodotto.
 */

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
