using System;

namespace Lesson05_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter x array (" + i + ") element :");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you_______________");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter y array (" + i + ") element :");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            //// Array1 + Array2
            //int[] z = new int[2 * n];
            //for (int i = 0; i < n; i++)
            //{
            //    z[i] = x[i];
            //    z[i + n] = y[i];
            //}
            //for (int i = 0; i < 2* n; i++)
            //{
            //    Console.WriteLine(z[i]);
            //}

        }
    }
}
