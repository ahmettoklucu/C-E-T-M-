using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 sayi giriniz");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 10)
                {
                    throw new SpecialException1();
                }
            }
            catch(SpecialException1 specialException)
            {
                Console.WriteLine("özel hata mesaji döndü",specialException);
            }
            catch(FormatException formatException)
            {
                Console.WriteLine("hata mesaji",formatException);

            } 
            catch(Exception exception)//herzaman en alttaki catch
            {
                Console.WriteLine("diğer hata mesaji",exception);
            }
            finally//her halükarda çalişir
            {
                Console.WriteLine("her halğkarda çalişir");

            }
        }
    }
}
