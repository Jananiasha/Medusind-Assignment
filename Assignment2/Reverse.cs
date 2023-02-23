using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Reverse
    {
        static void Main(string[] args)
        {   int l;
            Console.WriteLine("Enter a word:");
            string s = Console.ReadLine();
            l = s.Length - 1;
            string revtxt = "";
            for (int i = l; i >= 0; i--) 
            {
                revtxt += s[i];
            }
            Console.WriteLine(" Reverse Text: " + revtxt );
            Console.ReadLine(); 
        }
    }
}