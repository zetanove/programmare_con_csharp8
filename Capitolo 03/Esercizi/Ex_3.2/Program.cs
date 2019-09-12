using System;

namespace Ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = args[0];
            string cognome = args[1];
            Console.WriteLine($"Ciao {nome} {cognome}, oggi è il giorno {DateTime.Today:d} e sono le {DateTime.Now:HH:mm:ss}");
        }
    }
}
