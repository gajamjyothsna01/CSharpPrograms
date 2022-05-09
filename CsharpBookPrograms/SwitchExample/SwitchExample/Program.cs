using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string musicType = 'A';
            string musicType = "A";

            switch (musicType)
            {
                case "R":
                    Console.WriteLine("Rock and Roll rules");
                    break;
                case "B":
                    Console.WriteLine("Blues rules");
                    break;
                case "J":
                    Console.WriteLine("Jazz rules");
                    break;
                case "C":
                    Console.WriteLine("Classical rules");
                    break;
                default:
                    Console.WriteLine("You must not like music");
                    break;
            }
        }
    }
}
