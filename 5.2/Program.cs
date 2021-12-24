using System;
using Library;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mas = new double[8, 3];
            Console.WriteLine("Hello World!");
            for (int r = 0; r < mas.GetLength(0); r++)
            {
                for (int c = 0; c < mas.GetLength(1); c++)
                {
                    Console.WriteLine("Введите значение m[" + r + ", " + c + "]: ");
                    mas[r, c] = double.Parse(Console.ReadLine());
                }
            }
            Library.Matrix.arif(mas);
        }
    }
}
