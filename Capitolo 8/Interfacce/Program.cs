using System;

namespace Interfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");

            Report report = new Report();
            (report as IDocument).Save("path");
        }
    }
}
