using System;
using System.Drawing;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestSwitchExpression();
        }

        static void TestSwitchExpression()
        {
            object str = "abc";
            var x = str switch
            {
               
                string s when s.StartsWith("a") =>0,
                string { Length: 19 } => 1234,
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
    }
}
