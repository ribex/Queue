using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var testQueue = new Queue(10);

            var nameQueue = new Queue(5, "A", "B", "C");

            Console.WriteLine(testQueue);

            Console.WriteLine(nameQueue);

            nameQueue.Add("D");

            Console.WriteLine(nameQueue);

            var removeFirst = nameQueue.Remove();

            Console.WriteLine(nameQueue);
        }
    }
}
