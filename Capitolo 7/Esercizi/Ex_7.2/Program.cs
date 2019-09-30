using System;

namespace Ex_7._2
{
    class Rettangolo
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public double Area => CalcolaArea();

        public Rettangolo(double a, double b)
        {
            Base = b;
            Altezza = a;
        }

        public double CalcolaArea()
        {
            return Base * Altezza;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci lato a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci lato b:");
            double b = double.Parse(Console.ReadLine());


            Rettangolo rect = new Rettangolo(a, b);
            Console.WriteLine($"Area = {rect.Area}");
        }
    }
}
