using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //iki sayidan büyük olanını ekrana yazdir.
            string x;
            string y;
            int sayi1;
            int sayi2;
            m:
            Console.WriteLine("1.sayiyi giriniz.");
            x = (Console.ReadLine());
            bool tx =int.TryParse(x, out int  sonuc);
            if (tx == true)
            {
                sayi1 = Convert.ToInt32(x);
            }
            else
            {
                Console.WriteLine("lütfen sayi giriniz.");
                goto m;
            }
            n:
            Console.WriteLine("2.sayiyi giriniz.");
            y = (Console.ReadLine());
            bool ty = int.TryParse(y, out int sonuc2);
            if (ty == true)
            {
                sayi2 = Convert.ToInt32(y);
            }
            else
            {
                Console.WriteLine("lütfen sayi giriniz.");
                goto n;

            }


            if (sayi1 > sayi2)
            {
                Console.WriteLine(x + " sayisi büyüktür.");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine(y + " sayisi büyüktür.");
            }
            else
            {
                Console.WriteLine("iki sayi birbirine eşittir");
            }

        }
    }
}
