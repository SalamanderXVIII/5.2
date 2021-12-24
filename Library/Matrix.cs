using System;

namespace Library
{
    public class Matrix
    {
        public static double arif(double[,] mas)
        {
            double summ = 0;
            for (int r = 0; r < mas.GetLength(0); r++)
            {
                for (int c = 0; c < mas.GetLength(1); c++)
                {
                    summ += mas[r, c];
                }
            }
            double srarif = summ / (mas.GetLength(0) * mas.GetLength(1));
            return srarif;
        }
    }
}
