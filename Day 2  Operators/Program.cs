using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2__Operators
{
    class Program
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = Convert.ToDouble(meal_cost * tip_percent / 100);
            double tax = Convert.ToDouble(meal_cost * tax_percent / 100);
            double total_cost = meal_cost + tip + tax;

            Console.WriteLine(Math.Round(total_cost));
        }
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
