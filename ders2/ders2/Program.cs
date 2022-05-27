using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ADINIZ:");
            String isim = Console.ReadLine();

            Console.Write("SOYADINIZ:");
            String soyisim = Console.ReadLine();

            Console.Write("YAŞ:");
            int yas = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(isim+" "+ soyisim + " " + yas);
            Console.ReadLine();
        }
    }
}
