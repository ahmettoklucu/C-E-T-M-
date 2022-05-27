using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        v:
            Console.WriteLine("YAŞİNİZ:");
            var tyas = Console.ReadLine();
            bool fyas = int.TryParse(tyas, out int sonuc);
            if (fyas == true)
            {
                int yas = Convert.ToInt32(tyas);
            }
            else { goto v; }
               
                if (yas >= 18)
                {
                    Console.WriteLine("EHLİYET ALABİLİRSİNİZ");
                }
                else
                {
                    Console.WriteLine("EHLİYET ALAMAZSİNİZ");
                }
            }
        }
    }
}
