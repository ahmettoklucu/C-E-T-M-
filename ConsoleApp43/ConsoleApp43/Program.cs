using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add("u");
            arraylist.Add("o");
            arraylist.Add("i");
            arraylist.Add("q");
            arraylist.Add("e");
            arraylist.Add("r");
            arraylist.Add("z");
            arraylist.Add("a");
            arraylist.Add("f");
            arraylist.Add("b");
            arraylist.Sort();//a dan z ye siralar
            arraylist.Reverse();//diziyi ters çevirir

            
            foreach (string item in arraylist)
            {
                Console.WriteLine(item);
                
            }
            Console.ReadLine();

        }
    }
}
