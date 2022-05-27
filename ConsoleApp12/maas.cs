using System;

public class Class1
{
	public Class1()
	{

        void maas()
        {
        m:
            double maas1;
            double coc;
            double netmaas;
            Console.WriteLine("MAAŞİ GİRİNİZ");
            string x = Console.ReadLine();
            bool tx = double.TryParse(x, out double sonuc);

            if (tx == true)
            {
                maas1 = Convert.ToDouble(x);
                if (maas1 <= 4250)
                {
                    Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                    goto m;
                }
                else
                {
                z:
                    Console.WriteLine("ÇOCUK SAYİSİ GİRİNİZ");
                    string y = Console.ReadLine();
                    bool ty = double.TryParse(x, out double spwc);
                    if (ty == true)
                    {
                        coc = Convert.ToDouble(y);
                        if (coc < 0)
                        {
                            Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                            goto z;

                        }
                        else
                        {
                            if (coc < 3)
                            {
                                netmaas = maas1 + (maas1 * (coc * 0.5));
                                Console.WriteLine("MAAŞİNİZ:" + netmaas);
                            }
                            else
                            {
                                netmaas = maas1 + (maas1 * 0.15);
                                Console.WriteLine("MAAŞİNİZ:" + netmaas);
                            }


                        }

                    }
                    else
                    {
                        Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                        goto z;

                    }

                }
            }
            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");
                goto m;

            }
        }
        
    }
}
