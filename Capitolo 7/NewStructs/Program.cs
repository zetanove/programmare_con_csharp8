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

            PassStruct(ns);

            Container c = new Container();
            c.field = ns;
            c.spanInt= new Span<int>(new int[] { 1,2,3});

            ReadonlyPoint rpt = new ReadonlyPoint(0,0);
            //rpt.X = 0;
        }

        static void PassStruct(in NuovaStruct ns)
        {

        }
    }

    ref struct NuovaStruct
    {
        public int Num;
    }

    //ref struct che contiene altre ref struct
    ref struct Container
    {
        public NuovaStruct field;
        public Span<int> spanInt;
    }

    //struct immutabile
    public readonly struct ReadonlyPoint
    {
        public readonly double X;
        public readonly double Y;
        //public string errorField;
        public ReadonlyPoint(double x, double y) => (X, Y) = (x, y);

        public override string ToString() => $"({X}, {Y})";
    }
}
