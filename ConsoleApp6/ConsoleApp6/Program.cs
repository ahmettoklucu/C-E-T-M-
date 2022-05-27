using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            q:
            Console.Write("1.sayiyi giriniz:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sayiyi giriniz:");
            double x = Convert.ToDouble(Console.ReadLine());
            g:
            Console.Write("toplam=t \n çikartma=c \n çarma=p \n bölme=b \n SEÇİMİNİZİ YAPINIZ:");
            string islem = Console.ReadLine();

            if (islem == "t" || islem == "T")
            {
                Console.WriteLine("\n TOPLAM:" + (x + y));
                Console.ReadLine();
            }
            else if (islem == "c" || islem == "C")
            {
                Console.WriteLine("\n ÇİKARTMA" + (x - y));
                Console.ReadLine();
            }
            else if (islem == "p" || islem == "P")
            {
                Console.WriteLine("\n ÇARPMA:" + (x * y));
                Console.ReadLine();
            }
            else if (islem == "b" || islem == "B")
            {
                if (x == 0)
                {
                    Console.WriteLine("işlem geçersiz \n lütfen tekrar deneyiniz.");
                    Console.ReadLine();
                    Console.Clear();
                    goto q;
                }

                else { 
                Console.WriteLine("\n BÖLME:" + (x / y));
                Console.ReadLine();
                }
            }

            else
            {
                Console.WriteLine("LÜTFEN SEÇENEKLERDEN BİRİNİ YAZİNİZ");
                goto g;
            }

        }
    }
}
