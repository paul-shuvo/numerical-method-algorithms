using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewtonRaphson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. Pn_1             Pn\n");
            double ans = NewtonRaphson(-1, 0, .0001, 100);
            Console.WriteLine("Answer is {0}", ans);
            Console.ReadKey();
        }

        static double NewtonRaphson(double Strt_Intr, double End_intr, double Tol, int Max_Num_It)
        {
            double Pn_1 = ((Strt_Intr + End_intr) / 2);
            double Pn;
            int counter = 0;
            double tolerance = 10;
            double temp = 0, ret = 0;
            while (tolerance > Tol && counter <= Max_Num_It)
            {
                temp = Pn_1;
                Pn = Pn_1 - ((230*Math.Pow(Pn_1,4)+18*Math.Pow(Pn_1,3)+9*Math.Pow(Pn_1,2)-221*Pn_1-9)/(920*Math.Pow(Pn_1,3)+54*Math.Pow(Pn_1,2)+18*Pn_1-221));
                tolerance = temp - Pn;
                Console.WriteLine("{0}  {1}         {2}\n",counter,Pn_1,Pn);
                Pn_1 = Pn;
                ret=Pn_1;
                counter++;
                if (tolerance < 0)
                    tolerance *= (-1);
            }
            Console.WriteLine("Tolerance is {0}\n",tolerance);
            return ret;
        }
    }
}
