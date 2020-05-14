using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Dictionaries_and_Maps
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //The first line contains an integer, , denoting the number of entries in the phone book.
            int n = Convert.ToInt32(Console.ReadLine());

            //Each of the  subsequent lines describes an entry in the form of  space-separated values on a single line. 
            //The first value is a friend's name, and the second value is an -digit phone number.

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for(int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                if(inputs.Length == 1)
                {
                    phoneBook.Add(inputs[0], "");
                } else
                {
                    phoneBook.Add(inputs[0], inputs[1]);
                }
                
                
            }

            string query;
            while ((query = Console.ReadLine()) != null)
            {
                string output;
                if(phoneBook.TryGetValue(query,out output)){
                    Console.WriteLine("{0}={1}", query, output);
                } else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
