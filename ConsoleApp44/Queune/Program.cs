using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queune1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("iki");
            queue.Enqueue("bir");
            queue.Enqueue("üç");
            queue.Enqueue("dört");
            object o1 = queue.Peek();
            object o2 = queue.Dequeue();
            Console.ReadLine();
        }
    }
}
