using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = random.Next(1, 10);
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine("1 ile 10 arasinda 1 sayi giriniz");
                int m = Convert.ToInt32(Console.ReadLine());
                if (sayi == m)
                {
                    Console.WriteLine($"Sayi {sayi} idi {i}. denemenizde bildiniz");
                    break;
                }
                else if(sayi!=m&&i==9)
                {
                    Console.WriteLine($"{sayi} idi bilemediniz");
                }
                else
                {
                    Console.Write((9 - i) + "hakkınız kaldı.");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
