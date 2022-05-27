using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_outParametresi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 40, max;
            BigNumber(a, b, out max);
            Console.WriteLine("sayıların en büyüğü"+max);

        }
        private static void BigNumber(int a,int b,out int max)//out prametresi dışaridan değer almaz.Metho içerisinden değeri dişariya döndürür.method içerisinde mutlaka değer atmalıyım.
        {
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

        }
    }
}
