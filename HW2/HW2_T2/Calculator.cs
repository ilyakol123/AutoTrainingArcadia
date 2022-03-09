using System;

namespace HW2_T2
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double firstOperand = 0;
            double secondOperand = 0;

            firstOperand = PropertyInputCheck(firstOperand, "First Operand");
            secondOperand = PropertyInputCheck(secondOperand, "Second Operand");
            string operationSign = OperationInputCheck();
            Calculate(firstOperand, secondOperand, operationSign);
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
                    break;
                }
            }
            return property;
        }

        static string OperationInputCheck()
        {
            string[] supportedOperations = { "+", "-", "*", "/", "^" };

            while (true)
            {
                Console.WriteLine($"Enter the operation sign");
                string consoleInput = Console.ReadLine();
                
                foreach(string operation in supportedOperations)
                {
                    if (consoleInput.Equals(operation))
                    {
                        return operation;
                    }
                }
                Console.WriteLine("Entered operation is not supported");
            }
        }

        static void Calculate(double firstOperand, double secondOperand, string operationSign)
        {
            switch (operationSign)
            {
                case "+":
                    Console.WriteLine($"{firstOperand} {operationSign} {secondOperand} = {firstOperand + secondOperand}");
                    break;
                case "-":
                    Console.WriteLine($"{firstOperand} {operationSign} {secondOperand} = {firstOperand - secondOperand}");
                    break;
                case "*":
                    Console.WriteLine($"{firstOperand} {operationSign} {secondOperand} = {firstOperand * secondOperand}");
                    break;
                case "/":
                    Console.WriteLine($"{firstOperand} {operationSign} {secondOperand} = {firstOperand / secondOperand}");
                    break;
                case "^":
                    Console.WriteLine($"{firstOperand} {operationSign} {secondOperand} = {Math.Pow(firstOperand,secondOperand)}");
                    break;
            }
        }
    }
}
