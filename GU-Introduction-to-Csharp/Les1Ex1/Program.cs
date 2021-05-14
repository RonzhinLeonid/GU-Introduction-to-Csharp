using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1Ex1
{
    //Ронжин Л.
    //Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
    //Имя пользователя сохранить из консоли в промежуточную переменную.Поставить точку останова и посмотреть
    //значение этой переменной в режиме отладки. Запустить исполняемый файл через системный терминал
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            DateTime date = DateTime.Now;
            Console.WriteLine($"Привет, {name}. Сегодня {date:d} - {date.DayOfWeek}, текущее время {date:T}");
            Console.ReadKey();
        }
    }
}
