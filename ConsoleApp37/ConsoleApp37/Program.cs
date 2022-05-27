using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string sayi = " ";
            int[] sayilar = new int[6];
            for (int i = 0; i <sayilar.Length; i++)
            {
                n:
                int say = random.Next(1, 7);
                if (!sayi.Contains(say.ToString()))
                {
                    sayi = $"{sayi} {say}";
                    sayilar[i] = say;
                }
                else
                {
                    goto n;
                }
                
            }
            Console.WriteLine(sayi);
            Array.Sort(sayilar);//sayilar dizisini küçükten büyüğe siraladik
            foreach (int item in sayilar)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
