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
            //string[] isim = { "ayşe", "elif", "semra" };//diziyi oluşturulan tüm elemanlari girilerek oluşturuldu
            //int[] a = new int[5];//dizi tanımlanır ve eleman sayısı bildirilir
            //int[] b = new int[4] { 1, 2, 3, 4 };
            //int[] c = new int[4];
            //c[0] = 5;
            //c[1] = 8;
            //c[2] = 10;
            //c[3] = 6;
            //for(int i =0;i<= b.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine(b[i]);
            //}
            int toplam=0;
            double ortalama;
            Console.WriteLine("dizinin boyutu");
            int _diziBoyutu = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[_diziBoyutu];
            for (int i = 0; i <=dizi.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{i+1}.elemanini giriniz");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            foreach (int item in dizi)
            {
                toplam += item;
                Console.WriteLine(item);
            }
            ortalama = toplam / _diziBoyutu;
            Console.WriteLine($"Toplamı {toplam} ortalama {ortalama}");
            Console.ReadLine();
        }
    }
}
