using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Lets_Review
{
    class Program
    {
        public static string firstWord = "";
        public static string secondWord = "";

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!input.All(char.IsDigit) && i % 2 == 0)
                {
                    firstWord += input[i];
                }
                else if (!input.All(char.IsDigit) && i % 2 != 0)
                {
                    secondWord += input[i];
                }
            }
            Console.WriteLine(firstWord + " " + secondWord);
        }
    }
}
