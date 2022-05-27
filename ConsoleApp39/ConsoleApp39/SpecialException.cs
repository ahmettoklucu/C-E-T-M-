using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    public class SpecialException1:Exception
    {
        public SpecialException1()
        {
            Console.WriteLine("özel hata mesaji");

        }

    }
}
