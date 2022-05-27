using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a<5 ? $"Rakam {a}" : a<5 ? $"sayi 5 ten küçüktür": $" 5 ten büyüktür"  );
        }
    }
}
