using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5task2
{
    internal class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int[] Add(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }
        public int[] Subtract(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] - arr2[i];
            }
            return result;
        }
        public int[] Multiply(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }
            return result;
        }
        public int[,] Add(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            if (matrix2.GetLength(0) != rows || matrix2.GetLength(1) != cols)
                throw new ArgumentException("Matrices must have the same dimensions.");

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
    }
}
