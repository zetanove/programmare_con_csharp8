/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 4: operatore ref conditional
 */


using System;

namespace RefConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallArray = new int[] { 1, 2, 3, 4, 5 };
            var largeArray = new int[] { 10, 20, 30, 40, 50 };

            int index = 7;
            ref int refValue = ref ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]);
            refValue = 0;

            index = 2;
            ((index < 5) ? ref smallArray[index] : ref largeArray[index - 5]) = 100;

            Console.WriteLine(string.Join(" ", smallArray));
            Console.WriteLine(string.Join(" ", largeArray));
        }
    }
}
