using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex3
{
    class Program
    {
        //Ронжин Л.
        //3. Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            #region Способ 1
            Console.WriteLine("\nСпособ №1. Вывод строки наоборот по элементоно");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            #endregion

            #region Способ 2
            Console.WriteLine("\n\nСпособ №2. Получение новой строки");
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            Console.WriteLine(newStr);
            #endregion
            Console.ReadKey();
        }
    }
}
