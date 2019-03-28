using System;
using System.Linq;

namespace ExpressionVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var strings = new string[1];

            var r = from s in strings
                    select int.TryParse(s, out var i);
        }
    }


    public class A
    {
        public A(int i)
        {
        }

        public static int Magic = int.TryParse("123", out var i) ? i : 0;
    }

    public class B : A
    {
        public B(string s)
            : base(int.TryParse(s, out var i) ? i : 0)
        {
        }

        public B(int i): base()
        {

        }
    }
}
