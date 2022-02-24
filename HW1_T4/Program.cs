using System;

namespace HW1_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first line for concatination");
            string lineInput_1 = Console.ReadLine();
            Console.WriteLine("Enter second line for concatination");
            string lineInput_2 = Console.ReadLine();
            Console.WriteLine("Enter the symbol for concatination");
            char charInput = (char)Console.Read();

            string concatString = lineInput_1 + lineInput_2 + charInput.ToString();

            Console.WriteLine($"Index of {charInput} in {concatString}: {concatString.LastIndexOf(charInput)}");

        }
    }
}
