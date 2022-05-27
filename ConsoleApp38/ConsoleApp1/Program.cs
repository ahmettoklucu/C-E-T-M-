using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string isimGelen="";
        static string[] isimler = { "", "", "", "", "", "", "", "" };
        static int[] koltukNumarasi = { 0, 1, 2, 3, 4, 5, 6, 7 };
        static int koltukSecim = 0;
        static int say = 0;
        static void Main(string[] args)
        {
            isimAl();
            koltukKontrol();
            rezervasyon();
            if (say != koltukNumarasi.Length)
            {
                Main(null);//proğrami sürekli tekrar tekrar çaliştirir
            }
            Console.ReadLine();

        }

        private static void rezervasyon()
        {
            try
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltukSecim = Convert.ToInt32(Console.ReadLine());
                if (isimler[koltukSecim] == "")
                {
                    isimler[koltukSecim] = isimGelen;

                }
                else
                {
                    Console.WriteLine("SEÇTİĞİNİZ KOLTUK DOLU");
                }
                Console.WriteLine($"{koltukNumarasi[koltukSecim]} NUMARALİ KOLTUK {isimler[koltukSecim]} TARAFINDAN REZERVE EDİLMİŞTİR.");
                say++;
                koltukKontrol();
            }
            catch
            {
                Console.WriteLine("OLMAYAN KOLTUK SEÇİMİ");
                rezervasyon();
            }

        }

        private static void koltukKontrol()
        {
            for (int i = 0; i < isimler.Length;i++)
            {
                if (isimler[i] == "")
                {
                    Console.WriteLine($"{i}.koltuk boş");
                }
                else
                {
                    Console.WriteLine($"{i} . koltuk {isimler[i]} tarafindan dolu");
                }
            }
            if (say == koltukNumarasi.Length)
            {
                Console.WriteLine("SALON DOLU");
            }
            else
            {
                Console.WriteLine("SALON BOŞ");
            }
        }
        private static void isimAl()
        {
            Console.WriteLine("Adinizi giriniz");
            isimGelen = Console.ReadLine();
            for (int i = 0; i < isimGelen.Length; i++)
            {
                if (char.IsDigit(isimGelen[i]))//İsdigit sayisal değer döndürür.
                {
                    isimAl();
                }
            }

        }
    }
}
