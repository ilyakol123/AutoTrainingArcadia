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

            Console.WriteLine("First expression result: " + (x + y) * (z * z + 1));
            Console.WriteLine("Second expression result: " + ((x % z) - 1) * (Math.Sqrt(y)));
            Console.WriteLine("Third expression result: " + (((x * y) + (y * z)) / (Math.Pow(z, 3))));
        }
    }
}
