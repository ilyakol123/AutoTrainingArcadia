using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    class Matrix
    {
        private int MatrixRowsNumber { get; set; }
        private int MatrixColumnsNumber { get; set; }
        private double MatrixTrace { get; set; }
        private double [,] UserMatrix { get; set; }
        
        
        public Matrix MatrixInitialization()
        {
            Matrix matrix = new Matrix();
            var randomGenerator = new Random();
            int maxValueForDoubleRandom = 100;

            
            matrix.MatrixRowsNumber = SizeInput("rows");

            Console.WriteLine("");

            
            matrix.MatrixColumnsNumber = SizeInput("columns");

            Console.WriteLine("");
            matrix.UserMatrix = new double[matrix.MatrixRowsNumber, matrix.MatrixColumnsNumber];
            
            for (int i = 0; i < matrix.UserMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.UserMatrix.GetLength(1); j ++)
                {
                    matrix.UserMatrix[i, j] = randomGenerator.NextDouble() * maxValueForDoubleRandom;
                }
            }

            Console.WriteLine("CHECK THE MATRIX:");
            for (int i = 0; i < matrix.UserMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.UserMatrix.GetLength(1); j++)
                {
                    Console.Write(matrix.UserMatrix[i, j] + "  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            return matrix;
        }    

        public double MatrixTraceCalculation(Matrix matrix)
        {
           
            for (int i = 0; i < matrix.UserMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.UserMatrix.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        matrix.MatrixTrace += matrix.UserMatrix[i, j];
                    }
                }
            }

            return matrix.MatrixTrace;
        }

        static int SizeInput(string varString)
        {
            int size = 0;
            while (true)
            {
                Console.WriteLine($"Enter matrix {varString} number");
                string consoleInput = Console.ReadLine();
                if (int.TryParse(consoleInput, out size) == false)
                {
                    Console.WriteLine($"Enter the {varString} Integer number!");
                    Console.WriteLine("");
                }
                else
                {
                        if (size <= 0)
                        {
                            Console.WriteLine($"{varString} number can't be <= 0");
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
