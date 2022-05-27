using System;

public class Class1
{
	public Class1()
	{
        void kare()
        {
        z:
            Console.Write("1. kenar:");
            int a = str();
            Console.Write("2. kenar:");
            int b = str();
            Console.Write("3. kenar:");
            int c = str();
            Console.Write("4. kenar:");
            int d = str();
            if ((a == b && c == d) || (a == c && b == d) || (a == d && b == c))
            {

                if (a == b && a == c && a == d)
                {
                    Console.WriteLine("Bu kenarlardan oluşan bir karedir alani {0}", (a * b));
                }
                else
                {
                    Console.WriteLine("Bu kenarlardan oluşan bir dikdörtgendir");
                        if (a > b)
                        {
                        Console.Write(" alanı {0}", (a * b));
                        }
                        else if (a > c)
                        {
                        Console.Write(" alanı {0}", (a * c));
                        }
                        else
                        {
                        Console.Write(" alanı {0}", (a * d));
                        }
                }
            }
                else
                {
                Console.WriteLine("dikdörtgen veya karenin en az ikişer kenari eşittir. ");
                goto z;

                }


        }
    }
}
