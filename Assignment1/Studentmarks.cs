using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123
{
    class Studentmarks
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];

            Console.WriteLine("Enter Ten Marks:");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }

            int totalmarks = 0;
            int min = marks[0];
            int max = marks[0];
            for (int i = 0; i < 10; i++)
            {
                totalmarks += marks[i];
                if (marks[i] < min)
                {
                    min = marks[i];
                }
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }

            double avg = (double)totalmarks / 10;

            Console.WriteLine("Total marks: " + totalmarks);
            Console.WriteLine("Avg marks: " + avg);
            Console.WriteLine("Min marks: " + min);
            Console.WriteLine("Max marks: " + max);

            Array.Sort(marks);

            Console.WriteLine("Marks in Ascending order:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Marks in Descending order:");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}