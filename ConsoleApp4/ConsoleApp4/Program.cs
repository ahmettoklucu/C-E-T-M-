using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            
                Console.WriteLine
                    ("SMARTPRO'YA HOŞGELDİNİZ");
                Console.WriteLine
                    ("BİRİNCİ SAYİ GİRİNİZ:");
                int sayi1 =Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("ikinci sayiyi giriniz");
                int sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("iki sayinin toplami");
                Console.Write("sonucunuz:"+(sayi1+sayi2));
                Console.ReadLine();
            
        }
    }
}
