﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int portions = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(
                Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse));
            Console.WriteLine(orders.Max());
            while(orders.Any())
            {
                if(orders.Peek() <= portions)
                {
                    portions -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if(orders.Any())
            {
                Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
