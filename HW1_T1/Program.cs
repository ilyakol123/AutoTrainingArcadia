using System;

namespace HW1_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the \"x\" num");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the \"y\" num");
            double y = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the \"z\" num");
            double z = Double.Parse(Console.ReadLine());

            Console.WriteLine("First = " + (x + y) * (z * z + 1));
            Console.WriteLine("Second = " + ((x % z) - 1) * (Math.Sqrt(y)));
            Console.WriteLine("Third = " + (((x * y) + (y * z)) / (Math.Pow(z, 3))));
        }
    }
}
