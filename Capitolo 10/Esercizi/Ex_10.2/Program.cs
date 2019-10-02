using System;
using System.Collections.Generic;

namespace Ex_10._2
{
    class Program
    {
        public static Rubrica rubrica=new Rubrica(); 

        static void Main(string[] args)
        {
            var ch = Console.ReadKey();
            while(ch.Key!= ConsoleKey.X)
            {
                PrintMenu();
                ch = Console.ReadKey();
                switch(ch.Key)
                {
                    case ConsoleKey.S:
                        rubrica.Stampa();
                        break;
                    case ConsoleKey.I:
                        break;
                    case ConsoleKey.R:
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Rubrica");
            Console.WriteLine("Premi S per stampare la rubrica");
            Console.WriteLine("Premi I per inserire in rubrica");
            Console.WriteLine("Premi R per ricercare in rubrica");
        }
    }

    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Numero { get; set; }

        public override string ToString()
        {
            return $"{Cognome} {Nome}: {Numero}";
        }
    }

    class Rubrica
    {
        public List<Persona> persone;

        internal void Stampa()
        {
            foreach(var persona in persone)
            {
                Console.WriteLine(persona);
            }
        }
    }
}
