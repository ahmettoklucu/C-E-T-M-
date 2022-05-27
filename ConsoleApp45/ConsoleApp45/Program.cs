using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            string x= "After";
            Party(true);
            Party(true, x);
            Console.ReadLine();
        }
        public static void Party(bool x)
        {
            if (x)
            {
                Console.WriteLine("Partiye hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("GELMEZSEN GELME GELMEZSEN GELME");
            }
        }
        public static void Party(bool x,string name)
        {
            if (x)
            {
                Console.WriteLine($"{name} partiye hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("GELMEZSEN GELME GELMEZSEN GELME");
            }
        }
    }
}
