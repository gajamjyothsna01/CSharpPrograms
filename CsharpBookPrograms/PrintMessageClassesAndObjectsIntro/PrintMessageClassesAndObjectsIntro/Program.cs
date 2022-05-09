using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMessageClassesAndObjectsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RainMessage rainmessage = new RainMessage("Hello World!");
            Console.WriteLine(rainmessage);

        }
    }
}
