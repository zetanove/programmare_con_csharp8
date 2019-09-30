/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4:
 * Esercizio 4) Scrivere un’applicazione Console, con contesto nullable abilitato, che richieda
 * all’utente l’inserimento di una stringa, e poi ne stampi i primi due e gli ultimi
 * due caratteri.
 */

#nullable enable

using System;

namespace Ex_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una stringa:");
            string str = Console.ReadLine();

            if (str.Length > 1)
            {
                Console.WriteLine("primi due caratteri:" + str[0] + str[1]);
                Console.WriteLine("ultimi due caratteri:" + str[str.Length - 2] + str[str.Length - 1]);
            }
        }
    }
}
