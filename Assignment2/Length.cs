using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class len
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Text:");
            string s = Console.ReadLine();
            int leng = s.Length;
            Console.WriteLine("The length of the Text is " + leng );
            Console.Read(); 
        }
    }
}