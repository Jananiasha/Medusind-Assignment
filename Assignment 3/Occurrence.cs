using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Occurrence
    {
        public static void Main()
        {
            Console.WriteLine("Enter a String:");
            string ipstring = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letter = Console.ReadLine()[0];

            int ct = CounttheOccurrences(ipstring, letter);
            Console.WriteLine($"The letter {letter} appears {ct} times in the string.");
            Console.Read();
        }

        public static int CounttheOccurrences(string ipstring, char letter)
        {
            int ct = 0;

            foreach (char i in ipstring)
            {
                if (i == letter)
                {
                    ct++;
                }
            }

            return ct;
            
        }
    }
}