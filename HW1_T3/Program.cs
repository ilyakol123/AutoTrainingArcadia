using System;

namespace HW1_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first line");
            string input1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter second line");
            string input2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter third line");
            string input3 = Console.ReadLine().ToUpper();
            bool answer1;
            bool answer2;
            if (input1.StartsWith(input2))
            {
                answer1 = true;
            }
            else
            {
                answer1 = false;
            }

            if (input1.EndsWith(input3))
            {
                answer2 = true;
            }
            else
            {
                answer2 = false;
            }
            Console.WriteLine($"String {input1} starts from {input2}: {answer1}:");
            Console.WriteLine($"String {input1} ends with {input3}: {answer2}:");
        }
    }
}
