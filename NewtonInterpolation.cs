using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewtonInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of x and y values you want to input");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the given values of x and corresponding y values");
            double[] x_values = new double[n] ;
            double[] y_values = new double[n] ;
            int count = 0;
            while (count < n)
            {
                Console.WriteLine("Enter the value of x{0} and y{0}",count);
                x_values[count] = double.Parse(Console.ReadLine());
                y_values[count] = double.Parse(Console.ReadLine());
                count++;
            }
            double [] del_y_not=new double [n-1];
            double [] del_yn=new double [n-1];
            
            //double del_y = 0;
            
            double y1 = y_values[0];
            double y2 = y_values[n - 1];
            int count1 = n-1, count2 = 0, count3 = 0, count4 = 0;
            while (count1 > 0)
            {
                count2 = 0;
                while (count2 < count1)
                {
                    y_values[count2] = y_values[count2 + 1] - y_values[count2];
                    y_values[count2] = Math.Round(y_values[count2], 3);
                    //Console.WriteLine("yn is {0}", y_values[count2]);
                    count2++;
                }
                del_y_not[count3] = y_values[0];
                del_y_not[count3] = Math.Round(del_y_not[count3], 3);
                del_yn[count3] = y_values[count2 - 1];
                del_yn[count3] = Math.Round(del_yn[count3], 3);
                Console.WriteLine("y0 is {0}", del_y_not[count3]);
                Console.WriteLine("yn is {0}", del_yn[count3]);
                count3++;
                count1--;
            }
            int flag;
            double p,y_not;
            double desired_x;
            Console.WriteLine("Enter the value of x in order to find f(x)" );
            desired_x = double.Parse(Console.ReadLine());
            double check1 = (x_values[0] + x_values[n - 1])/2;
            if ((desired_x > x_values[0] && desired_x <= check1) || desired_x > x_values[n - 1])
            {
                flag = -1;
                p=(desired_x-x_values[0])/(x_values[1]-x_values[0]);
            }
            else
            {
                flag = 1;
                p=(desired_x-x_values[n-1])/(x_values[1]-x_values[0]);
            }
            Console.WriteLine(p);
            int count5 = 1;
            double reslt = 0;
            while (count4 < (n-1))
            {
                if (flag == -1)
                {
                    y_not = del_y_not[count4];
                }
                else
                {
                    y_not = del_yn[count4];
                }
                reslt = reslt + (mult(p,count5,flag) * y_not/Factorial(count4+1));
                Console.WriteLine("Result is {0}", reslt);
                count4++;
                count5++;
            }
            
            if (flag == -1)
            {
                reslt=reslt+y1;
            }
            else
            {
                reslt = reslt + y2;
            }
            reslt = Math.Round(reslt, 3);
            Console.WriteLine("Result is {0}",reslt);
            Console.ReadKey();
        }
        static double mult(double p, int x, int flg)
        {
            int count = 0;
            double res=1;
            if (flg == -1)
            {
                while (count < x)
                {
                    res = res * p;
                    p--;
                    count++;
                }
            }
            else
            {
                while (count < x)
                {
                    res = res * p;
                    p++;
                    count++;
                }
            }
            Console.WriteLine("P is {0}", res);
            return res;
        }
        static int Factorial(int x)
        {
            int res = x;
            x = x - 1;
            while (x > 0)
            {
                res = res * (x);
                x--;
            }
           
            return res;
        }
    }
}
