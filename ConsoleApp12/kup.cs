using System;

public class Class1
{
	public Class1()
	{
        void kup()
        {
            Console.Write("1. SAYİ GİRİNİZ: ");
            double say1 = dstr();
            Console.Write("2. SAYİ GİRİNİZ: ");
            double say2 = dstr();
            Console.Write("3. SAYİ GİRİNİZ: ");
            double say3 = dstr();
            double top = (say1 + say2 + say3);
            double sonuc = Math.Pow(top, 3);
            Console.Write("1.SAYİ {0} 2.SAYİ {1} 3.SAYİ {2} TOPLAMLARİ {3} KÜPLER {4}", say1, say2, say3, top, sonuc);
        }
           
    }
}
