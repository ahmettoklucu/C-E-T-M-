using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 sayi giriniz");
            int x = Convert.ToInt32(Console.ReadLine());
            while(x >= 0)
            {
                Console.WriteLine(x);
                x--;

            }
            Console.ReadLine();
        }
    }
}
