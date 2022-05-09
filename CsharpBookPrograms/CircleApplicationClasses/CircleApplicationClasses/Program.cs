using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplicationClasses
{
    
    public class Circle
    {
        int radius;
        float area;

        public Circle (int radius)
        {
            this.radius = radius;
            area = (float)(Math.PI * Math.Pow(radius, 2));
        }
        public int Radius
        {
            get { return radius; }
        }
        public float Area { get { return area; } }

    }
    class Program
    {
        static void Main(String[] args)
        {
            // create circle objects
            Circle circle0 = new Circle(0);
            Circle circle1 = new Circle(1);
            Circle circle2 = new Circle(2);
            Circle circle3 = new Circle(3);
            Circle circle4 = new Circle(4);
            Circle circle5 = new Circle(5);
            // print object info
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle0.Radius, circle0.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle1.Radius, circle1.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle2.Radius, circle2.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle3.Radius, circle3.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle4.Radius, circle4.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle5.Radius, circle5.Area);
            Console.WriteLine();


        }
    }

    
}
