using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
#nullable enable
            string str = null;
            var test = str.Substring(1);
#nullable disable
            string str2 = null;
        }
    }
}
