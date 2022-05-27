using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            //YENİ DEĞER EKLEME
            hashTable.Add("car", "araba");//hashTable.Add(x, y) x dem aymi olamaz y aynı olabilir.x=key,y=value
            hashTable.Add("house", "ev");
            hashTable.Add("cars", "arabalr");
            //yardimci metodlar
            bool control = hashTable.Contains("car");//keyde arama yapar
            bool control1 = hashTable.ContainsKey("house");//keyde arama yapar
            bool control2 = hashTable.ContainsValue("ev");//value de arama yapar


            hashTable["house"] = "villa";//indes yerine keyi verip value değerini değiştiriyoruz.
            hashTable.Remove("house");//house keyli indeksi siler

            int hshTbl = hashTable.Count;//hashtable kaça elemanli olduğunu gösterir
            hashTable.Clear();//hashtableyi temizler
        }
    }
}
