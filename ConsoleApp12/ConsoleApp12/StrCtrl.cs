using System;

public class StrCtrl
{

        public double dstr()
        {
        z:
            string x;
            x = Console.ReadLine();

            double y;

            bool tx = double.TryParse(x, out double sonuc);
            if (tx == true)
            {
                y = Convert.ToDouble(x);


            }
            else
            {
                Console.WriteLine("GEÇERLİ BİR DEĞER GİRİNİZ");
                goto z;
            }
            return y;


        }
        public int str()
        {
            z:
            string x;
            x = Console.ReadLine();

            int y;

            bool tx = int.TryParse(x, out int sonuc);
            if (tx == true)
            {
                y = Convert.ToInt32(x);


            }
            else
            {
                Console.WriteLine("GEÇERLİ BİR DEĞER GİRİNİZ");
                goto z;
            }
            return y;


        }
    }

