using ConsoleApp13;
using System;

namespace ConsoleApp13 { 
    public class SayiCtrl
    {
        public void Sayi()
        {
            StrCtrl strCtrl = new StrCtrl();
            Console.WriteLine("1 SAYİ GİRİNİZ");
            int x = strCtrl.İstr();
            Console.WriteLine(x<5 ? $" 5 ten küçük": x==5 ? $"5 e eşit ": $"5 te büyük");



        }
    }

}
