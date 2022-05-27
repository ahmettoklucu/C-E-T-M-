using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime  dateTime = DateTime.Now;
            DateTime date = new DateTime(2023, 1, 1);
            TimeSpan timeSpan = dateTime.Subtract(date);
            Console.WriteLine($"{Math.Abs(timeSpan.Days)} 2023 e kalan gün");
            Console.ReadLine();
        


        }
    }
}
