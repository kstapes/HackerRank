using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            //Converting an int to a string in the following method converts the int to binary 
            string binNumber = Convert.ToString(n, 2);
            int totalConseqNum = 0;

            //split the binary string on 0
            string[] binArray = binNumber.Split('0');

            for (int i = 0; i < binArray.Length; i++)
            {
                //if the totalConseqNum is less than the length of the element
                //in the array then set totalConseqNum to that length value
                if (totalConseqNum < binArray[i].Length)
                {
                    totalConseqNum = binArray[i].Length;
                }
                
            }
            Console.WriteLine(totalConseqNum);
            Console.ReadLine();
        }
    }
}
