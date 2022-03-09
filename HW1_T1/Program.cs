using System;

namespace HW1_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            x = PropertyInputCheck(x, "x");
            y = PropertyInputCheck(y, "y");
            z = PropertyInputCheck(z, "z");

            Console.WriteLine("First expression result: " + (x + y) * (z * z + 1));
            Console.WriteLine("Second expression result: " + ((x % z) - 1) * (Math.Sqrt(y)));
            Console.WriteLine("Third expression result: " + (((x * y) + (y * z)) / (Math.Pow(z, 3))));
        }

        static double PropertyInputCheck(double property, string varString)
        {
            while (true)
            {
                Console.WriteLine($"Enter the {varString} num");
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
