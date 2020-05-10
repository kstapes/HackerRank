using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Day_1_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int x;
            double y;
            string z;
            // Read and save an integer, double, and String to your variables.

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(x + i);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(String.Format("{0:0.0}", d + y));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + z);
        }
    }
}
