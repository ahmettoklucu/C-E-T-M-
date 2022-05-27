using System;

public class Vhsp
{
	public Vhsp()
	{

        void nthsp()
        {
            Console.Write("1.NOTU GİRİNİZ:");
        m:
            double n1 = dstr();
            if (n1 < 0 && n1 > 100)
            {
                Console.WriteLine("LÜTFEN 0-100 ARASİ BİR DEĞER GİRİNİZ");
                goto m;
            }
            else
            {

            }
            Console.Write("2.NOTU GİRİNİZ:");
        n:
            double n2 = dstr();
            if (n2 < 0 && n2 > 100)
            {
                Console.WriteLine("LÜTFEN 0-100 ARASİ BİR DEĞER GİRİNİZ");
                goto n;
            }
            else
            {

            }
            double ort = (n1 + n2) / 2;
            if (ort < 50)
            {
                Console.WriteLine("ORTALAMA NOTUNUZ:" + ort + " KALDİ");
            }
            else if (ort >= 50 && ort < 60)
            {
                Console.WriteLine("ORTALAMA NOTUNUZ:" + ort + " GEÇTİ");
            }
            else if (ort >= 60 && ort < 70)
            {
                Console.WriteLine("ORTALAMA NOTUNUZ:" + ort + " ORTA");
            }
            else if (ort >= 70 && ort < 85)
            {
                Console.WriteLine("ORTALAMA NOTUNUZ:" + ort + " İYİ");
            }

            else
            {
                Console.Write("ORTALAMA NOTUNUZ:" + ort + " PEKİYİ");
            }
        }
    }
}
