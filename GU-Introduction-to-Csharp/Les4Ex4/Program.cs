using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex4
{
    //Ронжин Л.
    //4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер числа из ряда Фибоначчи.");
            int n;
            do
            {
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
                else
                    Console.WriteLine("Данные некорректные, попробуйте еще раз.");
            } while (true);
            Console.WriteLine($"Число Фибоначчи для {n} равно {GetNumberFib(n)}");
            Console.ReadKey();
        }
        /// <summary>
        /// Получение числа Фибоначчи по его номеру в ряду.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int GetNumberFib(int n)
        {
            if (n==1 || n == 2) return 1;
            return GetNumberFib(n - 2) + GetNumberFib(n - 1);
        }
    }
}
