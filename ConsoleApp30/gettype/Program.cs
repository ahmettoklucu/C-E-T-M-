using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERİ GİRİNİZ");
            string s = Console.ReadLine();
            if(s is string)
            {
                Console.WriteLine($"Verinin tipi{s}");
            }
            Console.ReadLine();
        }
    }
}
