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
        public double [,] MatrixInitialization()
        {
            Matrix matrix = new Matrix();
            var randomGenerator = new Random();
            int maxValueForDoubleRandom = 100;
            Console.WriteLine("Enter matrix rows number ");
            matrix.MatrixRowsNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter matrix columns number ");
            matrix.MatrixColumnsNumber = int.Parse(Console.ReadLine());

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
            return matrix.UserMatrix;
        }    

        public double MatrixTraceCalculation(Matrix matrix)
        {


            return matrix.MatrixTrace;
        }
            
    }
}
