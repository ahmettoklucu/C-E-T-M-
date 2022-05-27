using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] dizi =new int[20];
            for (int i = 0; i <dizi.Length; i++)
            { 
                dizi[i]= random.Next(0, 11);
            }
            foreach (int item in dizi)
            {
                Console.Write(item +",");
            }
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                int adet = 0;
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (i == dizi[j])
                    {
                        adet++;
                    }
                }
                Console.WriteLine($"{i} sayisindan {adet} adet var.");
            }
            Console.ReadLine();
        }
    }
}
