using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }


            int maxValue = -64;    

            for(int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    int currentTotal = arr[i][x] + arr[i][x + 1] + arr[i][x + 2] + arr[i + 1][x + 1] + arr[i + 2][x] + arr[i + 2][x + 1] + arr[i + 2][x + 2]; 
                    if(maxValue < currentTotal)
                    {
                        maxValue = currentTotal;
                    }
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
