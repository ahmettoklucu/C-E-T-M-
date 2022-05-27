using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            for (int i = 1; i < 251; i++)
            {   
                if (i % 2 == 0)
                {
                    z += i;
                    
                }
                else
                {
                    Console.WriteLine(i);
                }       
            }
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
