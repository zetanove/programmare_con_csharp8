using System;

namespace HelloWorldVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            if (args != null && args.Length > 0)
                Console.WriteLine(args[0]);
        }
    }
}
