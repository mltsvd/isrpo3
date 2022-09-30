using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_3
{
    class Class2
    {
        public static void Init(out double[,] matr, int column, int row)
        {
            Random Rnd; Rnd = new Random();
            matr = new Double[row, column];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = Math.Round(Rnd.Next(10)+ Rnd.NextDouble(),2);
                }
            }
        }
        
        public static void Create(out double[,] matr, int column, int row)
        {
            matr = new double[row, column];
        }
        public static void Raschet(double[,] matr, out double summ)
        {
            int i, j;
            summ = 0;
            int kol = 0;
            double sumcount=0,a=0;
            for (j = 0; j < matr.GetLength(1); j++)
            {
                for (i = 0; i < matr.GetLength(0); i++)
                {
                    a = matr[i, j];
                    sumcount += a;
                    if (matr[i, j] == 0)
                    {
                        kol++;
                    }
                }
                if (kol >= 1)
                {
                    summ += sumcount;
                }
                sumcount = 0;
                kol =0;
            }
        }
    }
}
