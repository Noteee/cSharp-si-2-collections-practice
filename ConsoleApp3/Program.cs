using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    class Program
    {
        private static void Main(string[] args)
        {
            var queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            var stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                var obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
                Console.ReadKey();
            }

            while (queue.Count > 0)
            {
                var obj = queue.Dequeue();

                Console.WriteLine("From Queue: {0}", obj);
                Console.ReadKey();
            }
        }
    }
}