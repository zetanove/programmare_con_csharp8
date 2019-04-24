using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacce
{
    interface IDocument
    {
        void Print();
        void Save(string path)
        {
            Console.WriteLine($"IDocument.Save({path})");
        }
    }

    internal class Report : IDocument
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        //public void Save(string path)
        //{
        //    Console.WriteLine("Save " + path);
        //}
    }

}
