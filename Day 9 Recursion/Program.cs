using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Recursion
{
    class Program
    {
    static int factorial(int n)
        {
            int total = n;
            for (int x = n-1; x >= 1; x--)
            {
                total *= x;
                Console.WriteLine("total is " + total);
            }
            return total;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
