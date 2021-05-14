using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        //Ронжин Л.
        //Определить, является ли введённое пользователем число чётным.
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nСпособ 1");
            Console.WriteLine($"Число {n} {((n % 2 != 0) ? "не" : "")}чётное.");

            Console.WriteLine("\nСпособ 2");
            Console.WriteLine($"Число {n} {((n / 2 * 2 != n) ? "не" : "")}чётное.");

            Console.WriteLine("\nСпособ 3");
            Console.WriteLine($"Число {n} {(((n & 1) != 0) ? "не" : "")}чётное.");
            Console.ReadKey();
        }
    }
}
