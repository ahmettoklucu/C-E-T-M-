using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatayonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAYİ GİRİNİZ");
            try
            {
                int S = Convert.ToInt16(Console.ReadLine());
                Console.ReadLine();

            }
            catch (FormatException f)//belirli bir hata tipini yazma 
            {
                Console.WriteLine("hatalı format");
            }
            catch(Exception ex)//bütün hatalari karşiladiği için belirli hata tipinin altinda olmak zorundadir
            {
                Console.WriteLine($"Doğru formatta girmediniz{0}",ex);
            }

          
            Console.ReadLine();
        }
    }
}
