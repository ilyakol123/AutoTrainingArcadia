using System;

namespace HW3_1
{
    class MatrixTrace
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine("Matrix Trace =  "+ matrix.MatrixTraceCalculation(matrix.MatrixInitialization()));
            Console.ReadKey();
        }
    }
}
