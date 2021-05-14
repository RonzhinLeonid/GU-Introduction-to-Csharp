using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex2
{
    //Ронжин Л.
    //2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — 
    //сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел разделенных пробелом.");
            string str = Console.ReadLine();
            Console.WriteLine(SumNumbers(str));
            Console.ReadKey();
        }
        /// <summary>
        /// Сумма чисел в строке.
        /// </summary>
        /// <param name="str">набор чисел, разделенных пробелом</param>
        /// <returns></returns>
        static int SumNumbers(string str)
        {
            string[] words = str.Split(new char[] {' '});
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += Convert.ToInt32(words[i]);
            }
            return sum;
        }
    }
}
