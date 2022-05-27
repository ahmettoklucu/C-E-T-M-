using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Replace************");
            /*******Replace*******/
            //replace ile o metinde geçen metini diğer metine çevirir.
            string cumle = "merhaba deneme";
            Console.WriteLine(cumle);
            string yenicumle = cumle.Replace("mehaba", "nasılsınız");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("************Remove************");
            /*******Remove*******/
            string cml1 = "merhaba";
            string yncml1 = cumle.Remove(1);//remove(x) baştan x kadar karakete birakir geri kalani siler
            Console.WriteLine(yncml1);
            string yncml2 = cumle.Remove(0, 3);//remove(x,y) x indeksinden başlar y indeksine kadar siler
            Console.WriteLine(yncml2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            /*******Substring*******/
            Console.WriteLine("************Substring************");
            string cml2 = "merhaba dünya";
            string yncml3 = cml2.Substring(4);//substring(x) baştan x karakter siler geri kalani getirir
            Console.WriteLine(yncml3);
            string yncml4 = cml2.Substring(0, 9);///substring(x,y) x indeksinden başlar y inksine kadar getirir
            Console.WriteLine(yncml4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            /*******trim - trimend - trimstart * ******/
            Console.WriteLine("************trim-trimend-trimstart************");
            string yncml5 = cml2.Trim();//baştaki ve sondaki boşluklari yok eder.
            string yncml6 = cml2.TrimStart();//baştaki boşluklari yok eder.
            string yncml7 = cml2.TrimEnd();//sondaki boşluklari yok eder.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            /*******ToLower-ToUpper*******/
            Console.WriteLine("************ToLower-ToUpper************");
            string ynsml8 = cml2.ToLower();//tüm karakterleri küçük yapar
            string ynsml9 = cml2.ToUpper();//tüm karakterleri büyük yapar
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            /*******Lenght*******/
            Console.WriteLine("************Lenght************");
            Console.WriteLine(cml2.Length);
            int x = (cml2.Remove(0, 3)).Length;//merhaba dünya nın mer den sonrakşi karakterlerinin uzunluğunu veriri
            Console.WriteLine(x);
            /*******Lenght*******/
            Console.WriteLine("************Split************");
            string cml3 = "merhaba , nasılsın , ne yapıyorsun";
            for (int i = 0; i < cml3.Split(',').Length; i++)//split methodu dizi oluşturur split(x) x lerin olduğu yerlerden ayırarak dizi oluşturur.
            {
                Console.WriteLine(cml3.Split(',')[i]);//x.split('y') x cümlesinde y her y ye göre böl y lerin arasında kalanlar için indis oluştur.

            }
            Console.WriteLine("İSİM SOY İSİMİNİZİ GİRİNİZ");
            string nameSurname = Console.ReadLine();
            for (int i = 0; i < nameSurname.Split(' ').Length; i++)//her boşlukta bir dizi ögesi oluşturur.
            {
                Console.WriteLine(nameSurname.Split(' ')[i]);

            }





            Console.ReadLine();
        }
    }
}
