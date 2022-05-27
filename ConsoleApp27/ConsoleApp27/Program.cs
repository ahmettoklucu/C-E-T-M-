using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            for (; ; )
            {
                sayac++;
                    if (sayac == 100)
                    {
                    break;
                    }
                Console.WriteLine("ben bir sonsuz döngüyüm");
            }
            Console.ReadLine();
        }
    }
}
