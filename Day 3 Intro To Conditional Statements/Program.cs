﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Intro_To_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && (N >= 2 && N <= 5))
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && (N >= 6 && N <= 20))
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && (N > 20))
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}