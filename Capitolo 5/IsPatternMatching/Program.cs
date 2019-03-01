using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPatternMatching
{
    class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            /*TYPE PATTERN*/
            object obj = null;
            if (rand.Next() < 100)
                obj = "Hello, world";
            else obj = 123;

            if (obj is string str)
                Console.WriteLine($"lunghezza {str.Length}");

            //equivalente a 
            if (obj is string)
            {
                string s = (string)obj;
                Console.WriteLine($"lunghezza {s.Length}");
            }


            //pattern constant
            var x = "";
            bool test = x is null; //false

            DayOfWeek giorno = DateTime.Today.DayOfWeek;
            bool festive = giorno is DayOfWeek.Sunday; //true se oggi è domenica

            //var pattern

            MyClass mc = new MyClass();
            test = mc.IsValid(2);

            if (rand.Next() < 100)
                obj = "Hello, world";
            else obj = 123;
            if (obj is var y)
                Console.WriteLine($"E' un pattern Var con oggetto di tipo {y?.GetType()?.Name}");


            //combinazione di Type Pattern
            obj = "Hello world";
            if (obj is string res && res.Length > 5)
                Console.WriteLine(res.Length);
            else Console.WriteLine(0);

            Customer[] clienti = new Customer[5];
            clienti[0] = new Customer() { Name = "antonio", Telephone = null };
            clienti[1] = new Customer() { Name =  null, Telephone = null };
            clienti[2] = new Customer() { Name = "caterina", Telephone = null };
            clienti[3] = new Customer() { Name = "francy", Telephone = "456" };


            foreach(var customer in clienti)
            {
                if(customer is Customer { Telephone: null, Name: string n})
                {
                    Console.WriteLine($"Il cliente {n} non ha un numero di telefono");
                }
            }

            var a = new { x = 1, y = 2, z = 3 }; //x=1, y=2, z=3
            if (a is { x, y, z })
            {
            }

            Console.ReadLine();
        }
    }

    class Point3D

    public class MyClass
    {
        private int[] invalidValues = { 1, 4, 7, 9 };


        public bool IsValid(int value)
        {
            switch (value)
            {
                case var validValue when (!invalidValues.Contains(value)):
                    return true;

                case var invalidValue when (invalidValues.Contains(value)):
                    return false;

                default:
                    return false;

            }
        }
    }


}
