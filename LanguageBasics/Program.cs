using System;

namespace LanguageBasics
{
    class Util
    {
        public static int a = 5;
    }
    class Program
    {

        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var a = 5;
            var b = 6;

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a} and b = {b}");

        }
    }
}
