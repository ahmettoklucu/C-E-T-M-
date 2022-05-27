using System;

public class ortalama
{
	public Class1()
	{
        void ortalama()
        {
            string x;
            string y;
            string z;
            int not1;
            int not2;
            int soz1;
            int snc;
        m:
            Console.WriteLine("1.SİNAV NOTUNU GİRİNİZ ");
            x = Console.ReadLine();
            bool tx = int.TryParse(x, out int sonuc);

            if (tx == true)
            {
                not1 = Convert.ToInt32(x);
                if (not1 > 100 && not1 < 0)
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                    goto m;
                }
                else
                {

                }

            }
            else
            {
                Console.WriteLine("LÜTFEN BİR SAYİ GİRİNİZ");
                goto m;
            }
        n:
            Console.WriteLine("2.SİNAV NOTUNU GİRİNİZ ");
            y = Console.ReadLine();
            bool ty = int.TryParse(x, out int sonuc2);

            if (ty == true)
            {
                not2 = Convert.ToInt32(x);
                if (not2 > 100 && not2 < 0)
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                    goto n;
                }
                else
                {

                }


            }
            else
            {
                Console.WriteLine("LÜTFEN BİR SAYİ GİRİNİZ");
                goto n;
            }
        k:
            Console.WriteLine("SÖZLÜ NOTUNU GİRİNİZ ");
            z = Console.ReadLine();
            bool tz = int.TryParse(x, out int sonuc3);

            if (tz == true)
            {
                soz1 = Convert.ToInt32(x);
                if (soz1 > 100 && soz1 < 0)
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                    goto n;
                }
                else
                {

                }

            }
            else
            {
                Console.WriteLine("LÜTFEN BİR SAYİ GİRİNİZ");
                goto k;
            }

            snc = (not1 + not2 + soz1) / 3;
            if (snc > 50)
            {
                Console.WriteLine("GEÇTİNİZ");
            }
            else
            {
                Console.WriteLine("KALDİNİZ");
            }
        }
    }
}
