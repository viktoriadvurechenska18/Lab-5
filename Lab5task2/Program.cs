using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            int sum1 = math.Add(5, 3);
            int difference1 = math.Subtract(5, 3);
            int product1 = math.Multiply(5, 3);

            Console.WriteLine("Sum of two numbers: " + sum1);
            Console.WriteLine("Difference of two numbers: " + difference1);
            Console.WriteLine("Product of two numbers: " + product1);

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] sum2 = math.Add(array1, array2);
            int[] difference2 = math.Subtract(array1, array2);
            int[] product2 = math.Multiply(array1, array2);

            Console.WriteLine("Sum of two arrays: " + string.Join(", ", sum2));
            Console.WriteLine("Difference of two arrays: " + string.Join(", ", difference2));
            Console.WriteLine("Product of two arrays: " + string.Join(", ", product2));
        }
    }
    
}
    
