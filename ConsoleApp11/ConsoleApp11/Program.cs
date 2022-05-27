using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            string y;
            int sayi1;
            m:
            Console.WriteLine("BİR SAYİ YAZİNİZ");
            x = Console.ReadLine();
            bool tx = int.TryParse(x, out int sonuc);

            if (tx == true)
            {
                sayi1 = Convert.ToInt32(x);
                if (sayi1 % 3 == 0 && sayi1 % 5 == 0)
                {
                    Console.WriteLine("SAYİ 3 VE 5  TAM BÖLÜNMEKTEDİR");
                }
                else
                {
                    Console.WriteLine("SAYİ 3 VE 5 BÖLÜNMEMEKTEDİR");
                }
            }
            else
            {
                Console.WriteLine("LÜTFEN BİR SAYİ GİRİNİZ");
                goto m;
            }
            
            Console.ReadLine();
            string x;
            string y;
            int sayi1;
        m:
            Console.WriteLine("BİR SAYİ YAZİNİZ");
            x = Console.ReadLine();
            bool tx = int.TryParse(x, out int sonuc);

            if (tx == true)
            {
                sayi1 = Convert.ToInt32(x);
                if (sayi1 % 3 == 0 && sayi1 % 5 == 0)
                {
                    Console.WriteLine("SAYİ 3 VE 5  TAM BÖLÜNMEKTEDİR");
                }
                else
                {
                    Console.WriteLine("SAYİ 3 VE 5 BÖLÜNMEMEKTEDİR");
                }
            }
            else
            {
                Console.WriteLine("LÜTFEN BİR SAYİ GİRİNİZ");
                goto m;
            }

            Console.ReadLine();
        }
    }
}
