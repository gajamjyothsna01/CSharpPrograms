using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message rainMessage;
            Message rainMessage = new Message("Hello, world\n" +
"Chinese Democracy is done and it's November\n" +
"Is it raining?");
            rainMessage.Print();
            Console.WriteLine();

        }
    }
}
