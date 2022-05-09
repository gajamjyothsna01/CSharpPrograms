using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float gpa = 15.0f;
            if (gpa >= 3.0)
            {
                Console.WriteLine("You made Dean's List !!");
            }
            else if (gpa >= 2.0)
            {
                Console.WriteLine("Not on Dean's List this time. Keep trying.");
            }
            else
            {
                Console.WriteLine("You're on Academic Probation.");
            }

        }
    }
}
