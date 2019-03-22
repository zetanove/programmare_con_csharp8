using System;
using System.Collections.Generic;

namespace NewStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NuovaStruct ns = new NuovaStruct();
            ns.Num = 123;
            //object o = ns; //boxing non è possibile

        }
    }

    ref struct NuovaStruct
    {
        public int Num;
    }
}
