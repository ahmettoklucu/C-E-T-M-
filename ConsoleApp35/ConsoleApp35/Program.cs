using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = { "eda", "gül", "mehmet", "mustafa" };

            foreach (string item in isim)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
        }
    }
}
