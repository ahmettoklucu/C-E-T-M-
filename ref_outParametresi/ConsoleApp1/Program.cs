using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string metin="";
        static void Main(string[] args)
        {
            string x = Ctrl();
            string y = Ctrl();
            UzunOlan(x, y, out int max);
            Console.ReadLine();


        }
        private static void UzunOlan(string x,string y,out int max)
        {
            max = x.Length > y.Length ? x.Length : y.Length;
            Console.WriteLine($"maksimum {max}");
            //if (x.Length > y.Length)
            //{
            //    max = x.Length;
            //    Console.WriteLine($"uzun olan metin {x} {max} harftir.");
            //}
            //else
            //{
            //    max = y.Length;
            //    Console.WriteLine($"uzun olan metin {y} {max} harftir.");

            //}

        }
        private static string Ctrl()
        {
            Console.WriteLine("Metin giriniz");
            metin = Console.ReadLine();
            for (int i = 0; i < metin.Length; i++)
            {
                if (char.IsDigit(metin[i]))
                {
                    Console.WriteLine("lütfen geçerli bir değer giriniz");
                    Ctrl();
                }

            }
            return metin;
        }
    }
}
