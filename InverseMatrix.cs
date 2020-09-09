using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrx = new double[3, 3];
            Console.WriteLine("Enter Matrix A");
            int count1 = 0;
            while (count1 < 3)
            {
                Console.WriteLine("Enter the column {0} of the matrix", count1);
                matrx[count1,0] = double.Parse(Console.ReadLine());
                matrx[count1,1] = double.Parse(Console.ReadLine());
                matrx[count1,2] = double.Parse(Console.ReadLine());
                count1++;
            }
            double[] b = new double[3];
            Console.WriteLine("Enter the column of the Matrix b");
            b[0] = double.Parse(Console.ReadLine());
            b[1] = double.Parse(Console.ReadLine());
            b[2] = double.Parse(Console.ReadLine());
            Console.WriteLine("So the Matrix is:");
            Console.WriteLine("{0}  {1}  {2}     {3}", matrx[0, 0], matrx[1, 0], matrx[2, 0], b[0]);
            Console.WriteLine("{0}  {1}  {2}   =   {3}", matrx[0, 1], matrx[1, 1], matrx[2, 1], b[1]);
            Console.WriteLine("{0}  {1}  {2}     {3}", matrx[0, 2], matrx[1, 2], matrx[2, 2], b[2]);
            
            double deter = matrx[0, 0] * ((matrx[1, 1] * matrx[2, 2]) - (matrx[1, 2] * matrx[2, 1])) - matrx[1, 0] * ((matrx[0, 1] * matrx[2, 2]) - (matrx[0, 2] * matrx[2, 1])) + matrx[2, 0] * ((matrx[0, 1] * matrx[1, 2]) - (matrx[0, 2] * matrx[1, 1]));
            Console.WriteLine("Determinant is {0}", deter);
            double[,] A = new double[3, 3];
            A[0, 0] = (matrx[1, 1] * matrx[2, 2]) - (matrx[1, 2] * matrx[2, 1]);
            A[1, 0] = ((matrx[0, 1] * matrx[2, 2]) - (matrx[0, 2] * matrx[2, 1]))*(-1);
            A[2, 0] = (matrx[0, 1] * matrx[1, 2]) - (matrx[0, 2] * matrx[1, 1]);
            A[0, 1] = ((matrx[1, 0] * matrx[2, 2]) - (matrx[1, 2] * matrx[2, 0])) * (-1);
            A[1, 1] = (matrx[0, 0] * matrx[2, 2]) - (matrx[2, 0] * matrx[0, 2]);
            A[2, 1] = ((matrx[0, 0] * matrx[1, 2]) - (matrx[0, 2] * matrx[1, 0])) * (-1);
            A[0, 2] = (matrx[1, 0] * matrx[2, 1]) - (matrx[1, 1] * matrx[2, 0]);
            A[1, 2] = ((matrx[0, 0] * matrx[2, 1]) - (matrx[0, 1] * matrx[2, 0])) * (-1);
            A[2, 2] = (matrx[0, 0] * matrx[1, 1]) - (matrx[1, 0] * matrx[0, 1]);
            /*Console.WriteLine(A[0, 0]);
            Console.WriteLine(A[1, 0]);
            Console.WriteLine(A[2, 0]);
            Console.WriteLine(A[0, 1]);
            Console.WriteLine(A[1, 1]);
            Console.WriteLine(A[2, 1]);
            Console.WriteLine(A[0, 2]);
            Console.WriteLine(A[1, 2]);
            Console.WriteLine(A[2, 2]);*/
            count1 = 0;
            while (count1 < 3)
            {
                //Console.WriteLine("Enter the column {0} of the matrix", count1);
                matrx[count1, 0] = A[0, count1];
                matrx[count1, 1] = A[1, count1];
                matrx[count1, 2] = A[2, count1];
                count1++;
            }
            /*Console.WriteLine(matrx[0, 0]);
            Console.WriteLine(matrx[1, 0]);
            Console.WriteLine(matrx[2, 0]);
            Console.WriteLine(matrx[0, 1]);
            Console.WriteLine(matrx[1, 1]);
            Console.WriteLine(matrx[2, 1]);
            Console.WriteLine(matrx[0, 2]);
            Console.WriteLine(matrx[1, 2]);
            Console.WriteLine(matrx[2, 2]);*/
            double x= matrx[0,0]*b[0]+matrx[1,0]*b[1]+matrx[2,0]*b[2];
            double y= matrx[0,1]*b[0]+matrx[1,1]*b[1]+matrx[2,1]*b[2];
            double z= matrx[0,2]*b[0]+matrx[1,2]*b[1]+matrx[2,2]*b[2];
            x = x / deter;
            x = Math.Round(x, 3);
            y = y / deter;
            y = Math.Round(y, 3);
            z = z / deter;
            z = Math.Round(z, 3);
            Console.WriteLine("X = {0}\nY= {1}\nZ = {2}", x, y, z);
            Console.ReadKey();
        }
    }
}
