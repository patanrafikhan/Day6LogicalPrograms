﻿using System;

namespace fibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, val3, i, n;
            n = 7;

            Console.WriteLine("Fibonacci series :");
            Console.WriteLine(val1 + "" + val2 + "");
            for (i = 2; i < n; ++i)
            {
                val3 = val1 + val2;
                Console.WriteLine(val3 + "");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
