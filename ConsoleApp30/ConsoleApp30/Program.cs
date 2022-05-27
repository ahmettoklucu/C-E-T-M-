using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string psw = "1234";
            Console.WriteLine("PARALAYİ GİRİNİZ");
            int sayac = 5;
            
            while (sayac >= 1)
            {
                string x = Console.ReadLine();
                if(sayac==1&& psw != x)
                {
                    Console.WriteLine("ŞİFRE YANLİŞ GİRİŞ BAŞARİSİZ!!!");
                    break;
                }
                else if (psw == x)
                {
                    Console.WriteLine("GİRİŞ BAŞARİLİ");
                    break;
                }
                else if(sayac>1 && psw != x)
                {   sayac--;
                    Console.WriteLine($"{sayac} HAKKINIZ KALDI");  
                }
            }
            Console.ReadLine();
        }
    }
}
