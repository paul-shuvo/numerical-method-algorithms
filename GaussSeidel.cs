using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaussSeidel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of variables");
            int n = int.Parse(Console.ReadLine());
            int indx1=n,indx2=n;
            double [] con_var = new double[n];
            double [,]num_var = new double[indx1,indx2];
            int count1 = 0, count2, count3=0;
            while (count1 < n)
            {
                Console.WriteLine("Enter the values of equation {0}", count1+1);
                count2 = 0;
                while (count2 < n+1)
                {
                    if (count2 == n)
                    {
                        Console.WriteLine("Enter the constant value of equation {0}", count1 + 1);
                        con_var[count3] = double.Parse(Console.ReadLine());
                        Console.WriteLine(con_var[count3]);
                        count2++;
                        count3++;
                    }
                    else
                    {
                        Console.WriteLine("Enter the co-efficient of x{0}", count2 + 1);
                        num_var[count1, count2] = double.Parse(Console.ReadLine());
                        Console.WriteLine(num_var[count1, count2]);
                        count2++;
                    }
                }
                count1++;
            }
            double[] x_var = new double[n];
            set(x_var, n);
            //x_var[0] = get_val(num_var, con_var, x_var, 0, n);
            //Console.WriteLine(x_var[0]);
            solve(num_var, con_var, x_var, n, n, n);
            Console.WriteLine(x_var[0]);
            Console.WriteLine(x_var[1]);
            Console.WriteLine(x_var[2]);
            Console.WriteLine(x_var[3]);
            Console.ReadKey();
            
        }
        static void set(double []var,int size)
        {
            int i=0;
            while(i<size)
            {
                var[i] = 0;
                i++;
            }
        }
        static void set2(double[] var, int size)
        {
            int i = 0;
            while (i < size)
            {
                var[i] = 20;
                i++;
            }
        }
        static void solve(double[,] num_var, double[] con_var, double[] x_var, int size1, int size2, int size3)
        {
            double tol = 10;
            int n = size1;
            double [] check_x_var=new double[n];
            set(check_x_var,n);
            int count1 = 0;
            int count = 0;
            while (count!=n)
            {
                count = 0;
                count1 = 0;
                while(count1<size1)
                {
                    if (tol < 0.00001)
                    {
                        count++;
                    }
                    x_var[count1] = get_val(num_var, con_var,x_var,count1, size1);
                    //Console.WriteLine(x_var[count1]);
                    //Console.WriteLine("    ");
                    tol = check_x_var[count1] - x_var[count1];
                    if (tol < 0)
                    {
                        tol = tol * -1;
                    }
                    check_x_var[count1]=x_var[count1];
                    count1++;
                }
            }
        }
        static double get_val(double[,] num_var, double[] con_var, double [] x_var,int count,int size)
        {
            double x = 0;
            double denom=num_var[count,count];
            Console.WriteLine("denominator is {0}", denom);
            x = con_var[count] / denom;
            //Console.WriteLine("x is {0}", x);
            int i = 0;
            while (i < size)
            {
                if (count == i)
                {
                    i++;
                }
                else
                {
                    x = x - (num_var[count, i] / denom*x_var[i]);
                    i++;
                }
            }
            x = Math.Round(x, 7);
            //Console.WriteLine("x is {0}", x);
            return x;
        }
    }
}
