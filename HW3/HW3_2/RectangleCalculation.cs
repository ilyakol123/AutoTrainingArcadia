using System;

namespace HW3_2
{
    class RectangleCalculation
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(SizeInput("Side 1"), SizeInput("Side 2"));
            rectangle.AreaCalculator();
            rectangle.PerimeterCalculator();
        }

        static double SizeInput(string varString)
        {
            double size = 0;
            while (true)
            {
                Console.WriteLine($"Enter rectangle {varString}");
                string consoleInput = Console.ReadLine();
                if (Double.TryParse(consoleInput, out size) == false)
                {
                    Console.WriteLine($"Enter the {varString} number, not a string!");
                    Console.WriteLine("");
                }
                else
                {
                    if (size <= 0)
                    {
                        Console.WriteLine($"{varString} can't be <= 0");
                        Console.WriteLine("");
                        continue;
                    }

                    break;
                }
            }
            return size;
        }
    }
}
