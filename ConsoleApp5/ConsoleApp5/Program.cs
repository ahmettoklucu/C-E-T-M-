using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        a1:
            Console.Write("1.SİNAV:");
            var dsnv1 = Console.ReadLine();
            bool tfsnv1 = int.TryParse(dsnv1, out int sonuc);


            if (tfsnv1==true)
            {
                

            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz ");

                goto a1;
            }
            int snv1 = Convert.ToInt16(dsnv1);

        a2:

            Console.Write("2.SİNAV:");
            var dsnv2 = Console.ReadLine();
            bool tfsnv2 = int.TryParse(dsnv2, out int sonuc1);
            if (tfsnv2==true)
            {
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz ");
                dsnv2 = null;
                goto a2;
            }
            int snv2 = Convert.ToInt32(dsnv2);
        a3:

            Console.Write("3.SİNAV:");
            var dsnv3 = Console.ReadLine();
            bool tfsnv3 = int.TryParse(dsnv3, out int sonuc2);
            if (tfsnv3 == true)
            {
               
       
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz ");
                goto a3;
            }
            int snv3 = Convert.ToInt32(dsnv3);
            decimal ort = ((snv1 + snv2 + snv3) / 3);
            Console.WriteLine("ORTALAMA: " + ort);
            Console.ReadLine();
        }
    }
}
