using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 sayi giriniz");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x<0 ? $"sayi negatiftir {x}" : $"sayi pozitiftir");
            Console.ReadLine();
        }
    }
}
