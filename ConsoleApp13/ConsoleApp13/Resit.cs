using ConsoleApp13;
using System;

namespace ConsoleApp13
{
    public class Resit
    {
        public void Resit1()
        {
            StrCtrl strCtrl = new StrCtrl();
            Console.Write("Yaşinizi giriniz");
            int y = strCtrl.İstr();
            Console.WriteLine(y < 18 ? $" Reşit değisiz" : $"Reşitsizi");
        }
    }
}
