using System;

public class Class1
{
	public Class1()
	{
        void mevsim()
        {
        x:
            Console.WriteLine("1. YAZ \n 2. Kiş \n 3. ilkbahar \n 4 sonbahar");
            int a = str();
            switch (a)
            {
                case 1: Console.WriteLine("şort giy"); break;
                case 2: Console.WriteLine("Kaban giy"); break;
                case 3: Console.WriteLine("kot ceket"); break;
                case 4: Console.WriteLine("trenç kot giy"); break;
                default: Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ"); goto x;
            }
        }
    }
}
