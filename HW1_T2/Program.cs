using System;

namespace HW1_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 0;
            double hight = 0;
            double length = 0;

            width = PropertyInputCheck(width, "Width");
            hight = PropertyInputCheck(hight, "Hight");
            length = PropertyInputCheck(length, "Length");

            double diagonalLength = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(hight, 2) + Math.Pow(length, 2));

            Console.WriteLine("Parallelepiped diagonal length: " + diagonalLength);
        }

        static double PropertyInputCheck(double property, string varString)
        {
            while (true)
            {
                Console.WriteLine($"Enter the {varString}");
                string consoleInput = Console.ReadLine();
                if (Double.TryParse(consoleInput, out property) == false)
                {
                    Console.WriteLine("Enter the number, not a string!");
                }
                else
                {
                    if (property == 0)
                    {
                        Console.WriteLine($"{varString} can't be 0");
                    }
                    if (property < 0)
                    {
                        Console.WriteLine($"{varString} can't be negative");
                    }
                    if (property > 0)
                    {
                        break;
                    }
                }

            }
            return property;
        }
    }
}
