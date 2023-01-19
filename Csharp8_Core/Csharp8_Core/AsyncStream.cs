﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App
{
    public class AsyncStream
    {
        public static async Task EnumerateAsync()
        {
            Console.WriteLine($"Start: {DateTime.Now.ToLongTimeString()}");
            IAsyncEnumerable<int> numbersAsync = GetNumbersAsync(1, 10);
            await foreach (var number in numbersAsync)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"End: {DateTime.Now.ToLongTimeString()}");
            Console.ReadKey();
        }
        
        public static async IAsyncEnumerable<int> GetNumbersAsync(int start, int end)
        {
            var random = new Random();
           
            for (int i = start; i < end; i++)
            {
                await Task.Delay(random.Next(500, 1500));
                yield return i;
            }
        }
    }
}