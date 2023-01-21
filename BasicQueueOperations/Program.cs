using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] ints = Console.ReadLine().
                Split().Select(int.Parse).ToArray();
            int[] values = Console.ReadLine().
                Split().Select(int.Parse).ToArray();
            for(int i = 0; i < ints[0]; i++)
            {
                queue.Enqueue(values[i]);
            }
            for(int i = 0; i < ints[1] ; i++)
            {
                
                    queue.Dequeue();
                
            }
            if(queue.Count > 0)
            {
                if (queue.Contains(ints[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
