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
            //rpt.X = 0; //errore è sola lettura

            ref readonly ReadonlyPoint rrp = ref ReadonlyPoint.Origin;

            Point3DWrong p3dwrong = new Point3DWrong();
            ref var originReference = ref p3dwrong.Origin;
            originReference.Origin = new Point3DWrong(1,2,3);
            

            Point3D p3d = new Point3D();
            ref readonly var origRef2 = ref p3d.Origin;
            //origRef2.Origin = new Point3D(1,2,3) { }; //errore è readonly
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

        private static ReadonlyPoint origin = new ReadonlyPoint(0, 0);
        public static ref readonly ReadonlyPoint Origin => ref origin;
    }


    public struct Point3DWrong
    {
        public double x;
        public double y;
        public double z;
        public Point3DWrong(double _x,double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        private static Point3DWrong origin = new Point3DWrong(0, 0, 0);
        public ref Point3DWrong Origin => ref origin;
    }

    public struct Point3D
    {
        public double x;
        public double y;
        public double z;
        public Point3D(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        private static Point3D origin = new Point3D(0, 0, 0);
        public ref readonly Point3D Origin => ref origin;
    }

}
