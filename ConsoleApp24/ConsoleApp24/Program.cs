using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            n:
            int y;
            Console.WriteLine("KAÇ YİLDİZ YAZSİN");
            string x = Console.ReadLine();
            bool tx = int.TryParse(x, out int result);
            if (tx)
            {
                y = Convert.ToInt32(x);
                Console.Clear();
                for (int i = 1; i <= y; i++)
                {
                    for (int j = 1; j <=i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Lütfen GEÇERLİ BİR DEĞER GİRİNİZ ");
                goto n;
            }
            Console.ReadLine();
        }
    }
}
