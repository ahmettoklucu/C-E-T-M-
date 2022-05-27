using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isim = new string[10];
            for (int i = 0; i < isim.Length; i++)
            {
                isim[i] = " ";

            }
            for (int i = 0; i < 10; i++)
            {
                int say = 0;
                Console.WriteLine("İSMİNİZ");
                string name = Console.ReadLine();
                foreach (string item in isim)
                {
                    if (item == " ")
                    {
                        Console.WriteLine($"{say}.oda boş.");
                        say += 1;
                    }
                    else
                    {
                        Console.WriteLine($"{say}.odada {item} oturmaktadir");
                        say += 1;
                    }
                }
            v:
                Console.WriteLine("ODA SEÇİNİZ");
                int sec = Convert.ToInt32(Console.ReadLine());
                if (isim[sec] == " ")
                {
                    isim[sec] = name;

                }
                else
                {
                    Console.WriteLine("SEÇTİĞİNİZ ODA DOLUDUR LÜTFEN BAŞKA BİR ODA SEÇİNİZ");
                    goto v;
                }
            }
            Console.WriteLine("BÜTÜN ODALAR DOLU");
            Console.ReadLine();
        }
    }
}
