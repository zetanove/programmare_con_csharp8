/*
 * Programmare con C# 8 guida completa
 * Autore: Antonio Pelleriti
 * Appendice A: stringhe
 */
using System;

namespace Stringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            //costruzione
            string str = "Hello world";
            Console.WriteLine(str);

            str = new string("hello world"); //da C# 

            ReadOnlySpan<char> span = "hello world";
            str = new string(span);
            Console.WriteLine(str);

            str = new string('a', 10); // "aaaaaaaaaa"
            Console.WriteLine(str);
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            str = new string(arr, 1, 3); //"bcd"
            Console.WriteLine(str);


            str = "\\\u0045"; // \\ rappresenta il carattere \, \u0045 rappresenta il carattere E
            Console.WriteLine(str);

            str = @"c:\temp\file\a.txt"; //non è necessario raddoppiare i \
            Console.WriteLine(str);

            str = @"""Questa stringa è fra doppi apici"""; // "Questa stringa è fra doppi apici"
            Console.WriteLine(str);


            str = "hello";
            str = str + "world"; //helloworld
            Console.WriteLine(str);


            //stringhe nulle o vuote
            string empty = "";
            int len = empty.Length; //0


            String sn = null;
            str = "abc" + sn; //abc
            Console.WriteLine(str);

            //esaminare stringhe
            str = "hello";
            len = str.Length; //5
            char ch1 = str[0]; //h

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            foreach (char ch in str)
            {
                Console.WriteLine(ch);
            }

            char[] chars = str.ToCharArray(); //h,e,l,l,o
            chars = str.ToCharArray(0, 2); // h,e

            str = "hello world";
            int index = str.IndexOf('h'); //0
            index = str.LastIndexOf('l'); //3
            index = str.IndexOfAny(new char[] { 'l', 'w' }); //2

            str = "hello world";
            bool sb = str.StartsWith("hel"); //true
            bool eb = str.EndsWith("abc"); //false

            str = "hello world";
            bool cb = str.Contains("wo");//true
            bool cb2 = str.Contains("abc");//false
        }
    }
}
