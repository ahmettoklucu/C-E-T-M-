﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("{0}x{1}={2}    ", j, i, i * j);
                }
                Console.WriteLine("*******");
            }
            Console.ReadLine();
        }
    }
}
