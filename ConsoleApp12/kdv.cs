using System;

public class Class1
{
	public Class1()
	{
        void kdv()
        {
            Console.WriteLine("FİYAT GİR");
            int x = str();
        p:
            Console.WriteLine("1.GİDA" + "\n" + "2.TEKSTİL");
            int y = str();
            double s1 = Convert.ToDouble(x);
            if (y < 3)
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                goto p;
            }
            else
            {
                if (y == 1)
                {
                    s1 = x + (x * 0.1);
                    Console.WriteLine("ÜRÜN:GİDA" + "MATRAH:" + x + "TOPLAM" + s1);

                }
                else
                {
                    s1 = x + (x * 0.8);
                    Console.WriteLine("ÜRÜN:TEKSTİL" + "MATRAH:" + x + "TOPLAM" + s1);

                }



            }
        }
    }
}
