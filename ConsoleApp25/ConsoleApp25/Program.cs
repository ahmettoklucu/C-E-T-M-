using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.değer");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.değer");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x ==y)
            {
                Console.WriteLine("karedir");
            }
            else
            {
                Console.Clear();
                for (int i = 1; i <= x; i++)
                {
                    for(int j=1; j <= y; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }
            }
            Console.ReadLine();

        }
    }
}
