using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0, count = 0;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("ahmet");
            arrayList.Add(5);
            arrayList.Add("değer");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            arrayList.Add("deneme");
            capacity = arrayList.Capacity;//capacity otamatik olarak 2 kat 2 kati genişler
            count = arrayList.Count;//count arrayliste bulunan eleman değeridir
            Console.WriteLine($"dizinin kapasitesi={capacity},dizinin countu={count}");
            Console.WriteLine("arraylis 1 için yazilir");
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(5);
            arrayList1.Add(7);
            arrayList1.Add("eda");
            arrayList1.Add("ahmet");//1 DİZİNİN TAMAMİNİ DİĞER DİZİYE EKLER
            arrayList1.Remove(1);//DİZİNİN YAZİLAN İNDİSİNİ SİLER
            
            arrayList.AddRange(arrayList1);
            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.WriteLine(arrayList1[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            arrayList1.Reverse();//İNDEKSLERİ TAM TERSİ OLARAL ÇEVİRİR


            //arrayList.Sort();//TÜRLER AYNİ OLDUĞUNDA YAPILIR A DAN Z YE VE KÜÇÜKTEN BÜYÜĞE SİRALAR
            if (arrayList1.Contains("eda"))//eda varmi diye arariz//contains bool değer döndürur
            {
                int index = arrayList1.IndexOf("eda");
                arrayList1.Remove("eda");//eda varsa bulur siler
                //arrayList1.RemoveAt(index);//index gider ve indeksi siler
            }
            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.WriteLine(arrayList1[i]);
            }
            bool b = arrayList1.Contains(1);//arrayde 1 bul
            arrayList1.Clear();//arratlisti temizler
            ArrayList arrayList3 = new ArrayList();
            arrayList3.Add(5);
            arrayList3.Add(5);
            arrayList3.Add(12);
            arrayList3.Add("bhasbdsh");
            arrayList3.Add("jksdfjksd");
            Console.WriteLine($"kapasite={arrayList3.Capacity} countu={arrayList3.Count}");
            arrayList3.Remove(12);//12 sildik
            Console.WriteLine($"kapasite={arrayList3.Capacity} countu={arrayList3.Count}");//kapasite değişmez
            arrayList3.TrimToSize();//diziyi tekrar boyutlandirdik kapasite değişti
            Console.WriteLine($"kapasite={arrayList3.Capacity} countu={arrayList3.Count}");





            Console.ReadLine();
        }
    }
}
