using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class StrCtrl
    {
        public int İstr()
        {
            m:
            int y;
            string x = Console.ReadLine();
            bool tx = int.TryParse(x, out int result);
            if (tx)
            {
                y = Convert.ToInt32(x);

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                goto m;
            }
            return y;

        }
        public double Dstr()
        {
        m:
            double y;
            string x = Console.ReadLine();
            bool tx = double.TryParse(x, out double result);
            if (tx)
            {
                y = Convert.ToDouble(x);

            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                goto m;
            }
            return y;

        }
    }
}
