using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        private static string x;
        static string[] bussines = new string[10] { "", "", "", "", "", "", "", "", "", "" };
        static string[] ekonomi= new string[12] { "", "", "", "", "", "", "", "", "", "","","" };
        static int bussay = 0;
        static int ekosay = 0;
        static int rez;
        static string isim;

        static void Main(string[] args)
        {
            tursec();
        }
        static void tursec()
        {
            for (int i = 0; i <= bussines.Length + ekonomi.Length; i++)
            {


                Console.WriteLine("1-Bussines");
                Console.WriteLine("2-Ekonomi");
                x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        {
                            isimAl();
                            sec(bussines);
                            if (bussay < bussines.Length)
                            {
                                Console.WriteLine("salon boş");
                            }
                            else
                            {
                                Console.WriteLine("salon dolu");

                            }
                            rezervasyon(bussines);
                            bussay++;
                            break;
                        }
                    case "2":
                        {
                            isimAl();
                            sec(ekonomi);
                            if (ekosay < ekonomi.Length)
                            {
                                Console.WriteLine("salon boş");
                            }
                            else
                            {
                                Console.WriteLine("salon dolu");

                            }
                            rezervasyon(ekonomi);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("lütfen geçerli bir değer giriniz");
                            tursec();
                            break;
                        }
                }
            }
        }
        public static void isimAl()
        {
            Console.WriteLine("lütfen adınızı giriniz");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {
                if (char.IsDigit(isim[i]) == true)
                {
                    Console.WriteLine("lütfen geçerli bir değer giriniz");
                    isimAl();
                }
            }
        }

        public static void sec(string[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == "")
                {
                    Console.WriteLine($"{i}. koltuk boş");
                }
                else
                {
                    Console.WriteLine($"{i}. koltuk {m[i]} rezerve edilmiştir ");
                }

            }
        }
        public static void rezervasyon(string[] m)
        {
            try
            {
                rez = Convert.ToInt32(Console.ReadLine());
                if (rez < m.Length)
                {
                    if (m[rez] == "")
                    {
                        m[rez] = isim;
                    }
                }
                else
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                    rezervasyon(m);


                }

            }
            catch(FormatException)
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                rezervasyon(m);
            }
        }
    }
}



            


