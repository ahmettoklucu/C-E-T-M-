using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            t:
            int y = 0;
            int m = 1;
            Console.WriteLine("1.SAYİ GİRİNİZ");
            string x = Console.ReadLine();
            bool tx = int.TryParse(x, out int result);
            if (tx)
            {
                y = Convert.ToInt32(x);
                for (int i=y ;  i>=1 ; i--)
                {
                    m *= i;

                }
                Console.WriteLine("GİRİLEN SAYİNİN FAKTÖRİYELİ {0}",m);
                goto t;
               
            }
            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                goto t;
            }
            Console.ReadLine();
        }
    }
}
