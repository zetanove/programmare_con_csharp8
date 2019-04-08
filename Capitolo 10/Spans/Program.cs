using System;

namespace Spans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sp = IntroSpans();
            CreateSlices(sp);
        }

        private static Span<int> IntroSpans()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            var span1 = new Span<int>(arr1);
            span1[1] = 123;
            Console.WriteLine($"arr1[1] modificato tramite span1[1]:{arr1[1]}");
            return span1;
        }

        private static Span<int> CreateSlices(Span<int> span1)
        {
            Console.WriteLine(nameof(CreateSlices));
            int[] arr2 = { 3, 5, 7, 9, 11, 13, 15 };
            var span2 = new Span<int>(arr2);
            var span3 = new Span<int>(arr2, start: 3, length: 3);
            var span4 = span1.Slice(start: 2, length: 4);
            DisplaySpan("content of span3", span3);
            DisplaySpan("content of span4", span4);
            Console.WriteLine();
            return span2;
        }

        private static void DisplaySpan(string title, ReadOnlySpan<int> span)
        {
            Console.WriteLine(title);
            for (int i = 0; i < span.Length; i++)
            {
                Console.Write($"{span[i]}.");
            }
            Console.WriteLine();
        }
    }
}
