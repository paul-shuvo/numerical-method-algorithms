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
            Console.WriteLine("No.   Pn_1  Pn\n");
            double ans = Newton_Raphson(1, 2, .0001, 100);
            Console.WriteLine("Answer is {0}", ans);
            Console.ReadKey();
        }

        static double Newton_Raphson(double Strt_Intr, double End_intr, double Tol, int Max_Num_It)
        {
            double Pn_1=((Strt_Intr+End_intr)/2);
            double Pn;
            int counter = 0;
            double tollerance=10;
            double temp = 0, ret = 0;
            while (tollerance > Tol && counter <= Max_Num_It)
            {
                temp = Pn_1;
                Pn = (Pn_1 - (Math.Pow(Pn_1, 3) - (3 * Pn_1) - 5)/(3*Math.Pow(Pn_1,2)-3));
                tollerance = temp - Pn;
                Console.WriteLine("{0}  {1}         {2}\n",counter,Pn_1,Pn);
                Pn_1 = Pn;
                ret=Pn_1;
                counter++;
                if (tollerance < 0)
                    tollerance *= (-1);
            }
            Console.WriteLine("Tollerance is {0}\n",tollerance);
            return ret;
        }
    }
}
