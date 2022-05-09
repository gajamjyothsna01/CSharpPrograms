using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area;
            //Circle with Radius 0
            radius = 0;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: " + radius  +" " + "Area: " + area);
            Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            //Circle with Radius 1
            radius = 1;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: " + radius + " " + "Area: " + area);
            Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            //Circle with Radius 2
            radius = 2;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: " + radius + " " + "Area: " + area);
            Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);


            //Circle with Radius 3
            radius = 3;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: " + radius + " " + "Area: " + area);
            Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            //Circle with Radius 4
            radius = 4;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: " + radius + " " + "Area: " + area);
            Console.WriteLine("Radius: {0}, Area: {1}", radius, area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);
        }
    }
}
