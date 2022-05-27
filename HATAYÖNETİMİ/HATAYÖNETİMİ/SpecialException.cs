using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatayonetimi
{
    public class SpecialException:Exception
    {
        public SpecialExceptionMessege()
        {
            Console.WriteLine("özel hata mesaji");
        }
    }
}
