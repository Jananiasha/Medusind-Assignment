using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class Uppercase
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name:");
            string frstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string lstName = Console.ReadLine();

            Uppercase upp = new Uppercase();
            Display(frstName.ToUpper(),lstName.ToUpper());
        }

        public static void Display(string frstName, string lstName)
        {
            Console.WriteLine(frstName);
            Console.WriteLine(lstName);
            Console.Read();
        }
    }
}