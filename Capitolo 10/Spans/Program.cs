using System;

namespace Spans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sp = IntroSpans();
            EsempioSlice();
        }

        private static Span<int> IntroSpans()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            var span1 = new Span<int>(arr1);
            span1[1] = 123;
            Console.WriteLine($"arr1[1] modificato tramite span1[1]:{arr1[1]}");
            return span1;
        }

        private static void EsempioSlice()
        {
            Console.WriteLine(nameof(EsempioSlice));
            int[] arr1 = { 1,2,3,4,5,6,7,8,9,10 };
            DisplaySpan("contenuto arr1", arr1);
            var span2 = new Span<int>(arr1, start: 2, length: 4);

            DisplaySpan("contenuto span2", span2);
            for (int i = 0; i < span2.Length; i++)
                span2[i] *= 2;
            DisplaySpan("contenuto arr1 post modifica: ", arr1);

            var span3 = span2.Slice(start: 1, length: 3);
            DisplaySpan("contenuto span2", span2);
            DisplaySpan("contenuto span3", span3);
            Console.WriteLine();
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
