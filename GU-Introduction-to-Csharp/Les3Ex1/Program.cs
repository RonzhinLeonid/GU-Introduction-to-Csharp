using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Написать программу, выводящую элементы двухмерного массива по диагонали.
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Исходный двухмерный массив:");
            int[,] arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(100);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            #region Способ 1
            Console.Write("\nСпособ №1 с простыми условиями в цикле for:");
            Console.Write("\nГлавная диагональ: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(i==j) Console.Write($"{arr[i, j]} ");
                }
            }
            Console.Write("\nПобочная диагональ: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                {
                    if (i == arr.GetLength(1) - 1 - j) Console.Write($"{arr[i, j]} ");
                }
            }
            #endregion
            #region Способ 2
            Console.Write("\n\nСпособ №2 со сложными условиями в цикле for:");
            Console.Write("\nГлавная диагональ: ");
            for (int i = 0, j = 0; i < arr.GetLength(0) && j < arr.GetLength(1); i++, j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.Write("\nПобочная диагональ: ");
            for (int i = 0, j = arr.GetLength(1) - 1; i < arr.GetLength(0) && j >=0 ; i++, j--)
            {
                Console.Write($"{arr[i, j]} ");
            }
            #endregion

            #region Способ 2
            Console.Write("\n\nСпособ №3 с циклом while:");
            Console.Write("\nГлавная диагональ: ");
            int k = 0;
            while (k < arr.GetLength(0))
            {
                int z = 0;
                while (z < arr.GetLength(1))
                { 
                    if (k == z) Console.Write($"{arr[k, z]} ");
                    z++;
                }
                k++;
            }
            Console.Write("\nПобочная диагональ: ");
            k = 0;
            while (k < arr.GetLength(0))
            {
                int z = arr.GetLength(1)-1;
                while (z >= 0)
                {
                    if (k == arr.GetLength(1) - 1 - z) Console.Write($"{arr[k, z]} ");
                    z--;
                }
                k++;
            }
            #endregion
            Console.ReadKey();
        }
    }
}
