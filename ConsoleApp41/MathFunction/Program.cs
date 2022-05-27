using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            /***********ABS**********/
            Console.WriteLine("/***********ABS**********/");
            Console.WriteLine(Math.Abs(a));//ABS MUTLAK DEĞER

            /***********Sqrt**********/
            Console.WriteLine("/***********Sqrt**********/");
            Console.WriteLine(Math.Sqrt(a));//SQRT KARAKÖK

            /***********Ceiling/Round**********/
            Console.WriteLine("/***********Ceiling/Round**********/");
            double b = 2.4;
            Console.WriteLine(Math.Ceiling(b));//yukari yuvarlar
            Console.WriteLine(Math.Round(b));//yukari aşaği yukarlar0,5 sonra yukari

            /***********POW**********/
            Console.WriteLine("/***********POW**********/");
            Console.WriteLine(Math.Pow(a,3));
            Console.WriteLine(Math.Pow(5, 3));



            Console.ReadLine();
        }
    }
}
