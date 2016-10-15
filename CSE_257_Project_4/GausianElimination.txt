using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GausianElimination
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrx = new double[4, 3];
            Console.WriteLine("Enter Matrix A");
            int count1 = 0;
            while (count1 < 4)
            {
                Console.WriteLine("Enter the column {0} of the matrix", count1);
                matrx[count1, 0] = double.Parse(Console.ReadLine());
                matrx[count1, 1] = double.Parse(Console.ReadLine());
                matrx[count1, 2] = double.Parse(Console.ReadLine());
                count1++;
            }
            Console.WriteLine("So the Augmented Matrix is:");
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 0], matrx[1, 0], matrx[2, 0], matrx[3, 0]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 1], matrx[1, 1], matrx[2, 1], matrx[3, 1]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 2], matrx[1, 2], matrx[2, 2], matrx[3, 2]);
            double mul_fac = (matrx[0, 1] / matrx[0, 0]) * (-1);
            matrx[0, 1] = (matrx[0, 0] * mul_fac) + matrx[0, 1];
            matrx[1, 1] = (matrx[1, 0] * mul_fac) + matrx[1, 1];
            matrx[2, 1] = (matrx[2, 0] * mul_fac) + matrx[2, 1];
            matrx[3, 1] = (matrx[3, 0] * mul_fac) + matrx[3, 1];
            mul_fac = (matrx[0, 2] / matrx[0, 0]) * (-1);
            matrx[0, 2] = (matrx[0, 0] * mul_fac) + matrx[0, 2];
            matrx[1, 2] = (matrx[1, 0] * mul_fac) + matrx[1, 2];
            matrx[2, 2] = (matrx[2, 0] * mul_fac) + matrx[2, 2];
            matrx[3, 2] = (matrx[3, 0] * mul_fac) + matrx[3, 2];
            Console.WriteLine("Then the Matrix becomes:");
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 0], matrx[1, 0], matrx[2, 0], matrx[3, 0]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 1], matrx[1, 1], matrx[2, 1], matrx[3, 1]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 2], matrx[1, 2], matrx[2, 2], matrx[3, 2]);
            mul_fac = (matrx[1, 2] / matrx[1, 1]) * (-1);
            matrx[1, 2] = (matrx[1, 1] * mul_fac) + matrx[1, 2];
            matrx[2, 2] = (matrx[2, 1] * mul_fac) + matrx[2, 2];
            matrx[3, 2] = (matrx[3, 1] * mul_fac) + matrx[3, 2];
            mul_fac = (matrx[1, 2] / matrx[1, 1]) * (-1);
            matrx[1, 2] = (matrx[1, 1] * mul_fac) + matrx[1, 2];
            matrx[2, 2] = (matrx[2, 1] * mul_fac) + matrx[2, 2];
            matrx[3, 2] = (matrx[3, 1] * mul_fac) + matrx[3, 2];
            Console.WriteLine("So the Matrix becomes");
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 0], matrx[1, 0], matrx[2, 0], matrx[3, 0]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 1], matrx[1, 1], matrx[2, 1], matrx[3, 1]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 2], matrx[1, 2], matrx[2, 2], matrx[3, 2]);
            mul_fac = (matrx[1, 0] / matrx[1, 1]) * (-1);
            //Console.WriteLine(mul_fac);
            matrx[0, 0] = (matrx[0, 1] * mul_fac) + matrx[0, 0];
            matrx[1, 0] = (matrx[1, 1] * mul_fac) + matrx[1, 0];
            matrx[2, 0] = (matrx[2, 1] * mul_fac) + matrx[2, 0];
            matrx[3, 0] = (matrx[3, 1] * mul_fac) + matrx[3, 0];
            Console.WriteLine("So the Matrix becomes:");
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 0], matrx[1, 0], matrx[2, 0], matrx[3, 0]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 1], matrx[1, 1], matrx[2, 1], matrx[3, 1]);
            Console.WriteLine("{0}  {1}  {2}  {3}", matrx[0, 2], matrx[1, 2], matrx[2, 2], matrx[3, 2]);
            double x, y, z;
            z = matrx[3, 2] / matrx[2, 2];
            y = (matrx[3, 1] - (matrx[2, 1]*z)) / matrx[1, 1];
            x = (matrx[3, 0] - (matrx[2, 0]*z)) / matrx[0, 0];
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            z = Math.Round(z, 3);
            Console.WriteLine("X = {0}\nY= {1}\nZ = {2}", x, y, z);
            Console.ReadKey();
        }
    }
}
