using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int say = 5;
            int y=  Faktoriyel(say);
            Console.WriteLine(y);
            
            Console.ReadLine();
        }
        static int Faktoriyel(int say)
        {
            if (say == 0)
            {
                return 1;
            }

            return say * Faktoriyel(say - 1);

            
        }
    }
}
