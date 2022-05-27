using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            string y;
            int sayi1;
            int sayi2;
        n:
            Console.Write("1. sayiyi giriniz");
            x = Console.ReadLine();
            bool tx = int.TryParse(x, out int sonuc);
            if (tx == true)
            {
                sayi1 = Convert.ToInt32(x);
            }
            else
            {
                Console.Write("lütfen sayigiriniz");
                goto n;
            }
        m:
            Console.Write("2. sayiyi giriniz");
            y = Console.ReadLine();
            bool ty = int.TryParse(x, out int sonuc2);
            if (ty == true)
            {
                sayi2 = Convert.ToInt32(x);
            }
            else
            {
                Console.WriteLine("lütfen sayigiriniz");
                goto m;
            }
            if (sayi1 < 0)
            {
                Console.WriteLine("1.sayi negatif");
                
            }
            else if(sayi1>0)
            {
                Console.WriteLine("1.sayi pozitif");
                
            }
            else
            {
                Console.WriteLine("1.sayi sifirdir.");
            }

            if (sayi2 < 0)
            {
                Console.WriteLine("2.sayi negatif");
            }
            else if(sayi2>0)
            {
                Console.WriteLine("2.sayi pozitif");
            }
            else
            {
                Console.WriteLine("2.sayi sifirdir.");
            }
            Console.ReadLine();
        }
    }
}
