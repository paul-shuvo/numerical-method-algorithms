using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lagrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of x and y values you want to input");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the given values of x and corresponding y values");
            double[] x_values = new double[n];
            double[] y_values = new double[n];
            int count = 0;
            while (count < n)
            {
                Console.WriteLine("Enter the value of x{0} and y{0}", count);
                x_values[count] = double.Parse(Console.ReadLine());
                y_values[count] = double.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine("Enter the value of x");
            double x = double.Parse(Console.ReadLine());
            count = 0;
            double res = 0;
            while (count < n)
            {
                res = res + (((num_mult(x, x_values, n, count)) / (num_mult(x_values[count], x_values,n, count)) * y_values[count]));
                res = Math.Round(res, 4);
                count++;
            }
            Console.WriteLine("Result is {0}", res);
            Console.ReadKey();

        }
        static double num_mult(double x, double[] x_values, int size, int skip)
        {
            int count = 0;
            double res = 1;
            while (count < size)
            {
                if (count == skip)
                {
                    res = res * 1;
                }
                else
                {
                    res = res * (x - x_values[count]);
                }
                count++;
            }
            return res;
        }
        /*static double den_mult(double x, double[] x_values, int size, int skip)
        {
            int count = 0;
            double res = 1;
            while (count < size)
            {
                if (count == skip)
                {
                    res = res * 1;
                }
                else
                {
                    res = res * (x - x_values[count]);
                }
                count++;
            }
    }*/
    }
}
