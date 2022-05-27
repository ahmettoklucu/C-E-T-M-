using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static void Date()
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
        private static int ToplamAL(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        private static int Carpim(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public static int İCtrl()
        {
        v:
            string c = Console.ReadLine();

            int x;
            bool tx = int.TryParse(c, out int result);
            if (tx)
            {
                x = Convert.ToInt32(c);
                return x;
            }
            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                goto v;


            }
        }
        private static void ucgenHesapla(int aci1, int aci2)
        {
            int aci3;
            aci3 = 180 - aci1 - aci2;

            switch (aci3)
            {
                case int Ctrl when aci1 == aci2 && aci1 == aci3:
                    Console.WriteLine("EŞİT KENAR ÜÇGENDİR");
                    break;
                case int Ctrl when (aci1 == 90 || aci2 == 90 || aci3 == 90) &&
                    ((aci1 == aci2 && aci1 != aci3) || (aci1 == aci3 && aci1 != aci2)):
                    Console.WriteLine("DİK VE İKİZKENAR ÜÇGEN");
                    break;
                case int Ctrl when ((aci1 > 90 || aci2 > 90 || aci3 > 90)) &&
                    ((aci1 == aci2 && aci1 != aci3) || (aci1 == aci3 && aci1 != aci2)):
                    Console.WriteLine("GENİŞ VE İKİZKENAR ÜÇGEN");
                    break;
                case int Ctrl when (aci1 > 90 || aci2 > 90 || aci3 > 90) &&
                    (aci1 != aci2 && aci1 != aci3 && aci2 != aci3):
                    Console.WriteLine("GENİŞ KENAR ÜÇGEN");
                    break;
                case int Ctrl when
                ((aci1 == aci2 && aci1 != aci3) || (aci1 == aci3 && aci1 != aci2)):
                    Console.WriteLine("İKİZKENAR ÜÇGEN");
                    break;
                case int Ctrl when aci1!=aci2&&aci1!=aci3&&aci2!=aci3:
                    Console.WriteLine("ÇEŞİTKENAR");
                    break;


            }
        }
        private static void alanHesapla(int a, int b)
        {
            int sonuc = a * b;
            switch (sonuc)
            {
                case int kontrol when a == b:
                    Console.WriteLine($"KARENİN ALANİ{sonuc}");
                    break;
                case int kontrol when a != b:
                    Console.WriteLine($"DİKDÖRGENİN ALANİ{sonuc}");
                    break;
            }
        }

        private static void Main(string[] args)
        {
            x:

            Console.WriteLine("1.açiyi giriniz");
            int aci1 = İCtrl();
            Console.WriteLine("2.açiyi giriniz");
            int aci2 = İCtrl();
            int aci3 = 180 - aci1 - aci2;


            switch (aci2)
            {
                
                case int KONTROL when (aci1 <= 0) || (aci2 <= 0) || (aci3 <= 0):
                    Console.WriteLine("ÜÇGENİN AÇİLARİ TOPLAMİ 180 OLMALİDİR. BİR ÜÇGEN OLUŞMAMAKTADİR");
                    goto x;
                default:
                    ucgenHesapla(aci1, aci2);
                    break;

            }
            
            
            Console.ReadLine();

        }
    }
}
