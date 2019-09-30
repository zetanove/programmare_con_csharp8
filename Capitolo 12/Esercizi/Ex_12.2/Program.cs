using System;
using System.Linq;

namespace Ex_12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //opzione 1
            Console.WriteLine("Inserisci una frase");
            var str = Console.ReadLine();

            var counts = str.GroupBy(c => c) // raggruppa per ogni carattere                                                  
                     .OrderBy(c => c.Key)   // ordina alfabeticamente
                                            // converte in dizionario con chiave = carattere, e calore = il conteggio
                     .ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach(var c in counts)
            {
                Console.WriteLine($"{c.Key}: {c.Value}");
            }




        }
    }
}
