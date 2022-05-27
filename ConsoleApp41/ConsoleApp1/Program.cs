using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;//ŞUANKİ TARİHİ VERİR.
            Console.WriteLine(dateTime.ToShortDateString());//KİSA TARİH
            Console.WriteLine(dateTime.ToShortTimeString());//KİSA SAAT
            Console.WriteLine(dateTime.ToLongDateString());//UZUN TARİH
            Console.WriteLine(dateTime.ToLongTimeString());//UZUN SAAT
            Console.WriteLine(dateTime.Day);//GÜNÜ VERİR
            Console.WriteLine(dateTime.AddDays(5));//5 GÜN İLERİ TARİHİ VERİR
            Console.WriteLine(dateTime.AddDays(-5));//5 GÜN ÖNCEKİ TARİHİ VERİR
            Console.WriteLine(DateTime.DaysInMonth(2022, 2));//DateTime.DaysInMonth(X,Y) X YİLİNDA Y AYİNDA KAÇ GÜN VARDİR.
            Console.WriteLine(DateTime.IsLeapYear(2022));//
            
            


            Console.ReadLine();
        }
    }
}
