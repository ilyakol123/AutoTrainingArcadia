using System;

namespace HW1_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width");
            double width = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height");
            double hight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length");
            double length = Double.Parse(Console.ReadLine());

            double diagonalLength = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(hight, 2) + Math.Pow(length, 2));

            Console.WriteLine("Diagonal length = " + diagonalLength);
        }
    }
}
