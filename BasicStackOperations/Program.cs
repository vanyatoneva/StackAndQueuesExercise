using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] ints = Console.ReadLine().
                Split()
                .Select(int.Parse)
                .ToArray();
            int[] values = Console.ReadLine().
                Split().
                Select(int.Parse).ToArray();
            for(int i = 0; i < ints[0]; i++)
            {
                stack.Push(values[i]);
            }
            for(int i = 0; i < ints[1]; i++)
            {
                if(stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            if(stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(ints[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
