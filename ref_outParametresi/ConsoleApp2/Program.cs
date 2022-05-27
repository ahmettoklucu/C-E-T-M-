using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;
            //int kare=kareal(x, out int kup);
            //Console.WriteLine($"karesi {kare} küpü {kup} ");
            int x = 20, y = 10;
            Console.WriteLine($"x in ilk değeri {x} y nin ilk değeri {y}");
            degistir(ref x, ref y);
            Console.WriteLine($"x in son değeri {x} y nin son değeri {y}");

            Console.ReadLine();
        }

        private static void degistir(ref int x, ref int y)
        {
           int _x = x;
            x = y;
            y = _x;
        }

        private static void karekup(double x,out double y,out double z)
        {
           y = Math.Pow(x, 2);//x üssü 2
           z = Math.Pow(x, 3);//x üssü 3
        }
        private static int kareal(int a,out int kup)
        {
            int kare;
            kare = a * a;
            kup = kare * a;
            return kare;
        }
        //out sadece dişariya değer döndürmek için kullanılır.
        //hem method içerisinde değer almak hem dişariya değer döndürmek istersem ref i kullanırım.
        //değişkenin adresine göndermiş oluyorum
        //ref i kullanmak için değişken bir başlangıç değerine sahip olmak
    }
}
