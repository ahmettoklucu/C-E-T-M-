using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇOK_BOYULU_DİZİLER
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[7, 3]
            {
                {"istanbul","çanakkale","bursa"},
                {"izmir","manisa","muğla"},
                {"antalya","ısparta","mersin"},
                { "konya","ankara","sivas"},
                { "zonguldak","trabzon","rize"},
                { "gaziantep","mardin","şanliurfa"},
                { "ağrı","hakkari","van"}
            };
            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);

                }
                Console.WriteLine("***************");
            }
            Console.ReadLine();
        }
    }
}
