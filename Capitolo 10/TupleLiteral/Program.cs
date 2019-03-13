﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, string) tupla = (1, "Matilda"); //Tuple.Create<int, string>(1, "");
            Console.WriteLine(tupla);

            Coordinate coord = new Coordinate("Roma", 41.891930, 12.5113300);

            var (città, lat, lon) = coord;

            (char inizio, char fine, int lunghezza) = "Hello World";

            (inizio, fine, lunghezza) = "";


            //confronto
            var tupleA = (one: 1, three: 3, five: 5);
            var tupleB = (longa: 1L, longb: 3L, longc: 5L);

            if (tupleA == tupleB)
                Console.WriteLine("I valori coincidono.");
            else
                Console.WriteLine("I valori sono differenti.");

        }
    }

    public class Coordinate
    {
        public string Città { get; }
        public double Latitudine { get; }
        public double Longitudine { get; }

        public Coordinate(string città, double lat, double lon)
        {
            Città = città;
            Latitudine = lat;
            Longitudine = lon;
        }

        public void Deconstruct(out string città, out double latitudine, out double longitudine)
        {
            città = this.Città;
            latitudine = this.Latitudine;
            longitudine = this.Longitudine;
        }
    }

    public static class Extensions
    {
        public static void Deconstruct(this string s, out char first, out char last, out int length)
        {
            first = s.FirstOrDefault();
            last = s.LastOrDefault();
            length=s.Length;
        }
    }
}