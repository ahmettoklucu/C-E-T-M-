using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListSample
{
    class SpecialException:Exception
    {
        public SpecialException()
        {
            Console.WriteLine("LÜTFEN BİR DEĞER GİRİNİZ");
        }
    }
}
