﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_stars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('*');
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('*');
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
        
    

