using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3, }, { 5, 6, 7 } };
            /*
            Console.WriteLine("Enter the number of squares to print:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("The square of {0} is {1}" , i, i*i);
            }*/
            int sum = 0;
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int column = 0; column < numbers.GetLength(1); column++)
                {
                    sum += numbers[row, column];
                    Console.WriteLine(sum);
                }
            }
            Console.Write("Enter a GPA (0.0-4.0): ");
            double gpa = double.Parse(Console.ReadLine());
            // loop for a valid GPA
            while (gpa < 0.0 || gpa > 4.0)
            {
                // print error message and get new GPA
                Console.WriteLine("Invalid entry! GPA must be between 0.0 and 4.0.");
                Console.WriteLine();
                Console.Write("Enter a GPA (0.0-4.0): ");
                gpa = double.Parse(Console.ReadLine());
            }
        }
    }
}
