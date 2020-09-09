using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSE_257_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("No.  Pn-1  Pn-2   f(Pn-1)   f(Pn-2)   Pn    f(Pn)\n");
            double ans = False_Position(1, 2, .0001, 101);
            Console.WriteLine("Answer is {0}", ans);
            Console.ReadKey();
        }

        static double False_Position(double Strt_Intr, double End_intr, double Tol, int Max_Num_It)
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
                res_Pen2 = (3*start-Math.Exp(start));
                res_Pen1 = (3*end-Math.Exp(end));
                Pen = (start - (res_Pen2 / (res_Pen1 - res_Pen2))*(end - start));
                res_Pen = (3*Pen-Math.Exp(Pen));
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
           /* double P0 = Strt_Intr;
            double P1 = End_intr;
            double tollerance = 0;
            int counter = 2;
            double Q;
            double Q0=(Math.Pow(P0, 3) - (2 * P0 )- 5);
            double Q1=(Math.Pow(P1, 3) - (2 * P1 )- 5);
            while (counter <= Max_Num_It && tollerance<Tol)
            {
                double P;
                P=P0-((Q1/(Q1-Q0))*(P1-P0);
                tollerance=P1-P0;
                if((tollerance)<0)
                {
                    tollerance=tollerance*(-1);
                }
                Q=(Math.Pow(P, 3) - (2 * P )- 5);
                counter++;
                if((Q1*Q)<0)
                {
                    P0=P1;
                    Q0=Q1;
                }
                else
                {
                    P1=P;
                    Q1=Q;
                }
            }*/
        }
    }
}
