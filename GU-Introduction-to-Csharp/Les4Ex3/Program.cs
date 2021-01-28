using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex3
{
    //Ронжин Л.
    //3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
    //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
    //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
    //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 

    //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

    class Program
    {
        enum Season
        {
            Весна,
            Лето,
            Осень,
            Зима
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца.");
            int month;
            do
            {
                if (int.TryParse(Console.ReadLine(), out month))
                    break;
                else
                    Console.WriteLine("Данные некорректные, попробуйте еще раз.");
            } while (true);
            Console.WriteLine($"Текущее время года: {GetSeason(month)}");
            
            Console.ReadKey();
        }

        static string GetSeason(int month)
        {
            string season = "";
            switch (month)
            {
                case 1:
                case 2:
                case 12: season = Enum.GetName(typeof(Season), 3); break;
                case 3:
                case 4:
                case 5: season = Enum.GetName(typeof(Season), 0); break;
                case 6:
                case 7:
                case 8: season = Enum.GetName(typeof(Season), 1); break;
                case 9:
                case 10:
                case 11: season = Enum.GetName(typeof(Season), 2); break;
                default: Console.WriteLine("Ошибка: введите число от 1 до 12"); break;
            }
            return season;
        }
    }
}
