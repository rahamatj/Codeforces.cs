﻿using System;

namespace Watermelon4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());

            if (w % 2 == 0 && w > 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
