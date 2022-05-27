using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSample
{
    class Program
    {
        string ing;
        string tr;


        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            EvetHayir();
            Console.ReadLine();



        }
        public static void EvetHayir()
        {
            Console.WriteLine("YENİ KELİME EKLER MİSİNİZ?");
            string eh = (Console.ReadLine()).ToLower();

            switch (eh)
            {
                case "e": Ekleme(); EvetHayir(); break;
                case "h": listele(); break;

                default: Console.WriteLine("lütfen geçerli bir değer giriniz"); EvetHayir(); break;
            }

        }
        public static void Ekleme()
        {
            
            Console.WriteLine("İngilizce");
            string ing =kelimeAl();
            bool ctrl = hashtable.Contains(ing);
            if (ctrl)
            {
                Console.WriteLine("yazdiğiniz değer listede vardir");
            }
            else
            {
                Console.WriteLine("Türçesini yaziniz");
                string tr = kelimeAl();
                hashtable.Add(ing, tr);
            }
        }
        public static string kelimeAl()
        {
            Console.Write("değer giriniz");
          string x = Console.ReadLine();
            for (int i = 0; i < x.Length; i++)
            {
                if ((char.IsDigit(x[i]) == true))
                {
                    Console.WriteLine("lütfen geçerli bir değer giriniz");
                    kelimeAl();
                }
               
            }
            return x;
        }
        public static void listele()
        {
        foreach (var item in hashtable.Keys)
        {
            Console.WriteLine($"{item}  {hashtable[item]}");
        }
        }
    }
}

