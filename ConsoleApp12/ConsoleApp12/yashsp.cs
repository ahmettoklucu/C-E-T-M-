using System;

public class Class1
{
	

        public void yashsp()
        {

            int tgun = 0;
            int p;
            int r;
            Console.Write("DOĞUM GÜNÜ GİRİNİZ:");
        m:
            int dgun = str();
            if (dgun > 0 && dgun <= 31)
            {


            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
                goto m;
            }
            Console.Write("DOĞUM AYİ GİRİNİZ:");
        n:
            int day = str();
            if (day > 0 && day <= 12)
            {


            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
                goto n;
            }
            Console.Write("DOĞUM YİL GİRİNİZ:");
        z:
            int dyil = str();
            if (dyil > 0 && dyil <= 2022)
            {


            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
                goto z;
            }
            Console.Clear();
        nm:
            int bgun = DateTime.Now.Day;
            int bay = DateTime.Now.Month;
            int byil = DateTime.Now.Year;
            int bsaat = DateTime.Now.Hour;
            int bdakika = DateTime.Now.Minute;
            int bsaniye = DateTime.Now.Second;
            for (int x = dyil + 1; x < byil; x++)
            {
                if (x % 4 == 0)
                {
                    tgun += 366;

                }
                else
                {
                    tgun += 365;
                }

            }
            for (p = day + 1; p <= 12; p++)
            {
                if (p == 2)
                {
                    if (dyil % 4 == 0)
                    {
                        tgun += 29;
                    }
                    else
                    {
                        tgun += 28;
                    }
                }
                else if (p % 2 == 0)
                {
                    tgun += 30;
                }
                else
                {
                    tgun += 31;
                }

            }
            for (r = bay - 1; r > 0; r--)
            {
                if (r == 2)
                {
                    if (byil % 4 == 0)
                    {
                        tgun += 29;
                    }
                    else
                    {
                        tgun += 28;
                    }
                }
                else if (r % 2 != 0)
                {
                    tgun += 31;
                }
                else
                {
                    tgun += 30;
                }

            }
            tgun = tgun + dgun;
            tgun = tgun + bgun;
            int yasyil = tgun / 365;
            int kgun = tgun % 365;
            int yasay = kgun / 30;
            kgun = kgun % 30;

            Console.WriteLine("YAŞANAN {0} YİL  {1} AY  {2} GÜN {3} SAAT {4} DAKİKA {5} SANİYE", yasyil, yasay, kgun, bsaat, bdakika, bsaniye);
            System.Threading.Thread.Sleep(1000);


            if (bsaniye == DateTime.Now.Second)
            {

            }
            else
            {
                Console.Clear();
                tgun = 0;
                bay = 0;
                tgun = 0;
                kgun = 0;
                bgun = 0;
                byil = 0;
                goto nm;
            }
        }
    }
