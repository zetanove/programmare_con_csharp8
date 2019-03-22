using System;
using System.Drawing;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            int num = 1;
            switch (num)
            {

                case 1:

                    b = false;
                    goto case 2;
                case 2:
                    break;
            }

            //switch con string case sensitive
            string str = "";
            switch (str)
            {
                case "a":
                    break;
                case "A":
                    break;

            }

            //fall through
            Console.WriteLine("digita un tasto");
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("hai digitato la vocale {0}", c);
                    break;
                default:
                    Console.WriteLine("non hai inserito una vocale");
                    break;
            }

            DayOfWeek day = DateTime.Today.DayOfWeek;

            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("riposo");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("8:00 - 12:00");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("8:00 - 12:00 e 15:00 - 18:00");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("8:00 - 12:00");
                    break;
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("8:00 - 12:00");
                    break;
            }

            Person p = new Person() { FirstName = "Matilda" };


            string language = "ita";
            string greeting = null;

            switch(language)
            {
                case "eng":
                    greeting = "Hello";
                    break;
                case "spa":
                    greeting = "Hola";
                    break;
                case "ita":
                    greeting = "Ciao";
                    break;
                default:
                    greeting = "???";
                    break;
            }

            greeting = language switch
            {
                "eng" => "Hello",
                "spa" => "Hola",
                "ita" => "Ciao",
                _ => "???"
            };

            Console.WriteLine(greeting);

            language = "deu";
            greeting = language switch
            {
                "eng" => "Hello",
                "spa" => "Hola",
                "ita" => "Ciao",
                _ => "???"
            };

            Quadrato q=new Quadrato();
            q.Lato=5;
            Cerchio cerchio=new Cerchio();
            cerchio.Raggio=4;
           
            var areaQuadrato=CalcArea1(q);
            Console.WriteLine($"area quadrato {areaQuadrato}");
        }

        public static double CalcArea1(object obj)
        {
            switch(obj)
            {
                case Quadrato { Lato: 0 }:
                    return 0;               
                case Quadrato q:
                    return q.Lato * q.Lato;
                case Cerchio c:
                    return Math.PI * Math.PI * c.Raggio;

                default:
                    throw new NotImplementedException();
            };
        }

        public static double CalcArea(object obj)
        {
            return obj switch
            {
                Quadrato { Lato: 0 } => 0,
                Quadrato q => q.Lato * q.Lato,
                Cerchio c => Math.PI * Math.PI * c.Raggio,
                _ => throw new NotImplementedException()
            };
        }


        static void TestSwitchExpression()
        {
            object str = "abc";
            var x = str switch
            {
               
                string s when s.StartsWith("a") =>0,
                string { Length: 10 } => 1234,
                string s => s.Length,                
                _ =>1
            };
            Console.WriteLine(x);
        }

        static string Display(object o) => o switch
        {
            Point { X: 0, Y: 0 } p => "origin",
            Point { X: var x, Y: var y } p => $"({x}, {y})",
            _ => "unknown"
        };

        //static string Display(Customer o) => o switch
        //{
        //    { Telefono: null, DataNascita: var d } c when d.Year==1975 => "nato il "+c.DataNascita,
        //    Customer { Sesso: 'm'} p => $"maschio",
        //    _ => "unknown"
        //};


        class Figura
        {
            public double Area
            {
                get
                {
                    return this switch
                    {
                        Quadrato q when q.Lato < 0 => throw new ArgumentException(),
                        Quadrato q when q.Lato > 0 => q.Lato * q.Lato,
                        Cerchio c => c.Raggio * Math.PI * Math.PI,
                        _ => throw new NotImplementedException()
                    };
                }
            }

            
        }

        class Quadrato: Figura
        {
            public double Lato { get; set; }
        }

        class Cerchio : Figura
        {
            public double Raggio { get; set; }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

    }

}
