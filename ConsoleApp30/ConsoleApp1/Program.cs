using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            d:
            Console.WriteLine("LÜTFEN DOĞUM YİLİNİ GİRİNİZ");
            int yil = Convert.ToInt32(Console.ReadLine());
            int yas = DateTime.Now.Year - yil;
            switch (yas)
            {
                case int ctrl when yas >= 18:
                    Console.WriteLine("EHLİYET ALABİLİRSİNİZ");
                    break;
                case int ctrl when yas < 18:
                    Console.WriteLine("EHLİYET ALAMAZSİNİZ");
                   goto d;
            }
            Console.ReadLine();
        }
    }
}
