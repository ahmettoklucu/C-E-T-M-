using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            t:
            int m = 0;
            int z=0;
            double k = 0;
            Console.WriteLine("Kaç değer gireceksiniz");
            string y = Console.ReadLine();
            bool ty = int.TryParse(y, out int result2);
            if (ty)
            {
                m = Convert.ToInt32(y);
                for (int i = 1; i <= m; i++)
                {
                    Console.WriteLine("{0}.SAYİYİ GİRİNİZ",i);
                    q:
                    string x=Console.ReadLine();
                    bool tx = int.TryParse(x, out int result);
                    if (tx)
                    {
                        z += Convert.ToInt32(x);
                    }
                    else
                    {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                        goto q;
                    }
                }
                k = z / m;
                
                Console.WriteLine($"Girdiğiniz sayilarin toplami {z} ortalamasi {k}.");
           
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                goto t;

            }
            Console.ReadLine();
        }
    }
}
