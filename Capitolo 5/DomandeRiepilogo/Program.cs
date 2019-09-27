/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 5: domande riepilogo
 */

using System;

namespace DomandeRiepilogo
{
    class Program
    {
        static void Main(string[] args)
        {
            //domanda 1
            int a = 5;
            byte b = 2;
            int c = a / b;
            Console.WriteLine(c);//=2 risposta a

            //domanda 2
            c = a | b;
            Console.WriteLine(c);//=7 risposta b

            //domanda 3
            bool ba = true;
            bool bb = false;
            bool bc = !(ba && bb);
            Console.WriteLine(bc);//=true risposta b

            //domanda 4
            Domanda4();

            //domanda 5
            byte max = Byte.MaxValue;
            try
            {
                checked
                {
                    byte by = (byte)(max + 1);
                }
            }
            catch
            {
                Console.WriteLine("risposta c, si verifica un'eccezione");
            }

            //domanda 6
            if(A() && B())
            {
            }
            Console.WriteLine("risposta d, entrambi");

            //domanda 7
            string str = "abc";
            int? len = str?.Length ?? 0;
            Console.WriteLine(len); //= 3 risposta c

            //domanda 8
            string n = nameof(Main); 
            Console.WriteLine(n); // risposta a, nameof introdotto con C# 6

            //domanda 9m pattern matching con is
            object obj = "Hello world";
            if (obj is string s && s.Length > 5)
                Console.WriteLine(s.Length);
            else Console.WriteLine(0);

            Console.ReadLine();

        }

        public static bool A()
        {
            Console.WriteLine("Eseguo A");
            return true;
        }

        public static bool B()
        {
            Console.WriteLine("Eseguo B");
            return false;
        }

        public static void Domanda4()
        {
            bool a = true;
            bool b = false;
            bool c = !(a && b);
            Console.WriteLine(c); //true, risposta b
            
        }
    }
}
