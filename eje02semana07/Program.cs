﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Divisor de Sandy Solis : " + i + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
