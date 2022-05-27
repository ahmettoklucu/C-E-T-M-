using System;

public class Class1
{
	public Class1()
	{

        void Snv()
        {
            string x;
            string y;
            string z;
            int vize;
            int final;
            int soz1;
            Double snc;
            string son;
        m:
            Console.WriteLine("VİZE NOTUNU GİRİNİZ ");
            x = Console.ReadLine();
            bool tx = int.TryParse(x, out int sonuc);

            if (tx == true)
            {
                vize = Convert.ToInt32(x);
                if (vize > 100 && vize < 0)
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
            Console.WriteLine("FİNAL NOTUNU GİRİNİZ ");
            y = Console.ReadLine();
            bool ty = int.TryParse(x, out int sonuc2);

            if (ty == true)
            {
                final = Convert.ToInt32(x);
                if (final > 100 && final < 0)
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                    goto n;
                }
                else if (final <= 60)
                {
                    son = ("kaldiniz.");
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
            snc = (0.30 * vize) + (0.70 * final);
            if (final >= 60 && snc > 50)
            {
                Console.WriteLine("VİZE:" + vize + "FİNAL" + final + "GEÇTİNİZ");
            }

            else
            {
                Console.WriteLine("VİZE:" + vize + " FİNAL" + final + " KALDİNİZ");
            }
        }
    }
}
