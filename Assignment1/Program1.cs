using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program1
{
    static void Main(string[] args)
    {
        int[] arr = new int[5]{ 30,43,67,85,100 };

        int sum = 0;
        int min = arr[0];
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        double avg = (double)sum / arr.Length;

        Console.WriteLine("Avg: " + avg);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
        Console.Read();
    }
}