using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FalsePosition
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("No.  Pn-1  Pn-2   f(Pn-1)   f(Pn-2)   Pn    f(Pn)\n");
            double ans = FalsePosition(1, 2, .0001, 101);
            Console.WriteLine("Answer is {0}", ans);
            Console.ReadKey();
        }

        static double FalsePosition(double Strt_Intr, double End_intr, double Tol, int Max_Num_It)
        {
            
            double start = Strt_Intr;
            double end = End_intr;
            int counter = 2;
            double tollerance=10;
            double temp = 0, ret = 0;
            while (tollerance > Tol && counter <= Max_Num_It)
            {
                double Pen;
                double res_Pen1;
                double res_Pen2;
                double res_Pen;
                res_Pen2 = (Math.Pow(start, 3) - (1 * start )- 1);
                res_Pen1 = (Math.Pow(end, 3) - (1 * end) - 1);
                Pen = (start - (res_Pen2 / (res_Pen1 - res_Pen2))*(end - start));
                res_Pen = (Math.Pow(Pen, 3) - (1 * Pen) - 1);
                Console.WriteLine("{0}     {1}     {2}      {3}      {4}      {5}       {6}\n", counter, end, start, res_Pen2, res_Pen1, Pen, res_Pen);
                if ((res_Pen * res_Pen2) < 0)
                {
                    end = Pen;
                }
                else 
                {
                    start = Pen;
                }
                tollerance = temp - Pen;
                temp = Pen;
                if (tollerance < 0)
                {
                    tollerance=tollerance* (-1);
                }
                
                ret = Pen;
                counter++;
                
            }
            Console.WriteLine("tol is {0}", tollerance);
            return ret;
        }
    }
}
