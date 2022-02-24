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

            while (true)
            {
                Console.WriteLine("Enter the width");
                string consoleInput = Console.ReadLine();
                if (Double.TryParse(consoleInput, out width) == false)
                {
                    Console.WriteLine("Enter the number, not a string!");
                }
                else
                {
                    if (width == 0)
                    {
                        Console.WriteLine("Width can't be 0");
                    }
                    if (width < 0)
                    {
                        Console.WriteLine("Width can't be negative");
                    }
                    if (width > 0)
                    {
                        break;
                    }
                }

            }

            while (true)
            {
                Console.WriteLine("Enter the hight");
                string consoleInput = Console.ReadLine();
                if (Double.TryParse(consoleInput, out hight) == false)
                {
                    Console.WriteLine("Enter the number, not a string!");
                }
                else
                {
                    if (hight == 0)
                    {
                        Console.WriteLine("Hight can't be 0");
                    }
                    if (hight < 0)
                    {
                        Console.WriteLine("Hight can't be negative");
                    }
                    if (hight > 0)
                    {
                        break;
                    }
                }

            }

            while (true)
            {
                Console.WriteLine("Enter the length");
                string consoleInput = Console.ReadLine();
                if (Double.TryParse(consoleInput, out length) == false)
                {
                    Console.WriteLine("Enter the number, not a string!");
                }
                else
                {
                    if (length == 0)
                    {
                        Console.WriteLine("Length can't be 0");
                    }
                    if (length < 0)
                    {
                        Console.WriteLine("Length can't be negative");
                    }
                    if (length > 0)
                    {
                        break;
                    }
                }

            }


            double diagonalLength = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(hight, 2) + Math.Pow(length, 2));

            Console.WriteLine("Parallelepiped diagonal length: " + diagonalLength);
        }
    }
}
