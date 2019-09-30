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
                Console.WriteLine("risposta d, si verifica un'eccezione");
            }

            //domanda 5
            if(A() && B())
            {
            }
            Console.WriteLine("risposta d, entrambi");

            //domanda 6
            string str = "abc";
            int? len = str?.Length ?? 0;
            Console.WriteLine(len); //= 3 risposta c

            //domanda 7
            char ch = str.Length > 3 ? str[^1] : str[0];
            Console.WriteLine(ch); //= a risposta a

            //domanda 8 pattern matching con is
            object obj = "Hello world";
            if (obj is string s && s.Length > 5)
                Console.WriteLine(s.Length);
            else Console.WriteLine(0); //=11 risposta c

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
