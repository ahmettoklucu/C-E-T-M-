using System;

public class Class1
{
	public Class1()
	{


        void kiyas()
        {
            string x;
            string y;
            string z;
            int say1;
            int say2;
            int say3;
            int byk;
            int kck;
            int est;
        m:
            Console.Write("1.SAYİYİ GİRİNİZ: ");
            x = Console.ReadLine();
            bool tx = int.TryParse(x, out int sonuc);
            if (tx == true)
            {
                say1 = Convert.ToInt32(x);
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
                goto m;
            }
        n:
            Console.Write("2.SAYİYİ GİRİNİZ: ");
            y = Console.ReadLine();
            bool ty = int.TryParse(y, out int sonuc1);
            if (ty == true)
            {
                say2 = Convert.ToInt32(y);
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
                goto n;
            }
        k:
            Console.Write("3.SAYİYİ GİRİNİZ: ");
            z = Console.ReadLine();
            bool tz = int.TryParse(x, out int sonuc2);
            if (tz == true)
            {
                say3 = Convert.ToInt32(z);
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir değer giriniz");
                goto k;
            }
            if (say1 > say2 && say1 > say3)
            {
                Console.WriteLine("1.EN BÜYÜK: " + say1);
            }
            else if (say2 > say1 && say2 > say3)
            {
                Console.WriteLine("2.EN BÜYÜK: " + say2);
            }
            else if (say3 > say1 && say3 > say2)
            {
                Console.WriteLine("3.EN BÜYÜK: " + say3);
            }

            if (say1 == say2 && say1 == say3 && say2 == say3)
            {
                Console.WriteLine("ÜÇ SAYİ BİR BİRİNE EŞİTTİR");

            }
            else if (say1 == say2 && say1 != say3 && say2 != say3)
            {
                Console.WriteLine("1. VE 2. SAYİ BİR BİRİNE EŞİTTİR");

            }
            else if (say3 == say2 && say3 != say1 && say2 != say1)
            {
                Console.WriteLine("2. VE 3. SAYİ BİR BİRİNE EŞİTTİR");

            }
            else if (say1 == say3 && say1 != say2 && say3 != say2)
            {
                Console.WriteLine("1. VE 3. SAYİ BİR BİRİNE EŞİTTİR");

            }
            else
            {
                Console.WriteLine("EŞİTLİK YOKTUR");
            }

            if (say3 < say1 && say3 < say2)
            {
                Console.WriteLine("3.EN KÜÇÜK: " + say3);
            }
            else if (say2 < say1 && say2 < say3)
            {
                Console.WriteLine("2.EN KÜÇÜK: " + say2);

            }

            else
            {
                Console.WriteLine("1.EN KÜÇÜK: " + say1);
            }
        }
    }
}
