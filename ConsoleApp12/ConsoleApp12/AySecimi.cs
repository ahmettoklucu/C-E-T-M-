using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class AySecimi
    {
        public void Secim()
        {
            StrCtrl strCtrl = new StrCtrl();
            Console.WriteLine("Ayi Seciniz");
            m:
            int x = strCtrl.str();
            switch (x)
            {
                case 1: Console.WriteLine("Kiş Mevsimi"); break;
                case 2: Console.WriteLine("Kiş Mevsimi"); break;
                case 3: Console.WriteLine("İlkbahar Mevsimi"); break;
                case 4: Console.WriteLine("İlkbahar Mevsimi"); break;
                case 5: Console.WriteLine("İlkbahar Mevsimi"); break;
                case 6: Console.WriteLine("Yaz Mevsimi"); break;
                case 7: Console.WriteLine("Yaz Mevsimi"); break;
                case 8: Console.WriteLine("Yaz Mevsimi"); break;
                case 9: Console.WriteLine("Sonbahar Mevsimi"); break;
                case 10: Console.WriteLine("Sonbahar Mevsimi"); break;
                case 11: Console.WriteLine("Sonbahar Mevsimi"); break;
                case 12: Console.WriteLine("Kiş Mevsimi"); break;
                default: Console.WriteLine("Lütfen Geçerli bir Değer Giriniz");
                    goto m;

            }

        }
    }
}
