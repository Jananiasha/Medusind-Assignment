using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class sameornot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Word:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Word:");
            string s2 = Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine("The Words are the Same.");
            }
            else
            {
                Console.WriteLine("The Words are Not the Same.");
            }
            Console.ReadLine();
        }
    }
}