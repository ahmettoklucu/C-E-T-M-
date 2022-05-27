using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last İN LAST OUT MANTİĞİYLA ÇALİŞİR
            Stack stack = new Stack();
            stack.Push("BEŞ");//SON DEĞERİ İLKE ALİYOR
            stack.Push("İKİ");
            stack.Push("ÜÇ");
            stack.Push("DÖRT");
            Object O1 = stack.Pop();//SON ELEMANİ LİSTEDEN SİLER
            Object O2 = stack.Peek();//SON ELEMANİ VERİRİ
        }
    }
}
