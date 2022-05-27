using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVERLOAD
{
    class Program
    {
        static int[] sayilar = { 1, 5, 6, 7, 8 };
        static void Main(string[] args)
        {
            string metin = "ahmet", metin2 = "toklucu";
            int a = 1, b = 2;
            int say = 0;

            Console.WriteLine(ToplamAl(metin, metin2));
            Console.WriteLine(ToplamAl(sayilar));

            for (int i = 0; i < 11; i++)
            {
                say = ToplamAl(i, say);

            }
            Console.WriteLine(say);
            Console.ReadLine();


        }
        public static int ToplamAl(int[] vs)
        {
            int say=0;
            foreach (var item in vs)
            {
                say += item;
            }
            return say;
        }
        public static string ToplamAl(string a,string b)
        {
            return a + " " + b;
        }
        public static int ToplamAl(int a, int b)
        {
            return a + b;
        }

    }
}
