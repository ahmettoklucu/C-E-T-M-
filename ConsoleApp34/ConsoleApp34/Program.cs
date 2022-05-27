using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int cift = 0;
            int tek = 0;
            int sayac = 0;
            do
            {
                Console.WriteLine(sayac %2== 0 ? sayac + ":ÇİFT" : sayac + ":TEK");
                cift = sayac % 2 == 0 ? cift += sayac : tek += sayac;
                sayac++;
            }
            while (sayac <= 100);
            Console.WriteLine($"TEKLERİN TOPLAMI :{tek} ÇİFT TOPLAM {cift}");
            Console.ReadLine();
        }
    }
}
