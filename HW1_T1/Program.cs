using System;

namespace HW1_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine("First = " + (x + y) * (z * z + 1));
            Console.WriteLine("Second = " + ((x % z) - 1) * (Math.Sqrt(y)));
            Console.WriteLine("Third = " + (((x * y) + (y * z)) / (Math.Pow(z, 3))));
        }
    }
}
