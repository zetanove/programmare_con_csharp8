using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //stampa la stringa Hello World!
            if (args != null && args.Length > 0)
                Console.WriteLine($"args: {string.Join(',', args)}");

            Console.WriteLine("Hello World!");

            Index i1 = 3;  // number 3 from beginning
            Index i2 = ^4; // number 4 from end
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"{a[i1]}, {a[i2]}"); // "3, 6"

            Console.Read();
        }
    }
}
