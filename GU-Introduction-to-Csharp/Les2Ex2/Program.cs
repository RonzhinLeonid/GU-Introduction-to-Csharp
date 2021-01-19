using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2Ex2
{
    class Program
    {
        //Ронжин Л.
        //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        static void Main(string[] args)
        {
            Console.Write("Укажите порядковый номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            string monthTitle = "";
            #region switch
            switch (month)
            {
                case 1: monthTitle = "январь"; break;
                case 2: monthTitle = "февраль"; break;
                case 3: monthTitle = "март"; break;
                case 4: monthTitle = "апрель"; break;
                case 5: monthTitle = "май"; break;
                case 6: monthTitle = "июнь"; break;
                case 7: monthTitle = "июль"; break;
                case 8: monthTitle = "август"; break;
                case 9: monthTitle = "сентябрь"; break;
                case 10: monthTitle = "октябрь"; break;
                case 11: monthTitle = "ноябрь"; break;
                case 12: monthTitle = "декабрь"; break;
                default: Console.WriteLine("Неверно введен номер месяца"); break;
            }
            if (monthTitle != "") Console.WriteLine($"Указанный месяц: {monthTitle}");
            #endregion

            #region if else
            monthTitle = "";
            if (month == 1) monthTitle = "январь";
            else if (month == 2) monthTitle = "февраль";
            else if (month == 3) monthTitle = "март";
            else if (month == 4) monthTitle = "апрель";
            else if (month == 5) monthTitle = "май";
            else if (month == 6) monthTitle = "июнь";
            else if (month == 7) monthTitle = "июль";
            else if (month == 8) monthTitle = "август";
            else if (month == 9) monthTitle = "сентябрь";
            else if (month == 10) monthTitle = "октябрь";
            else if (month == 11) monthTitle = "ноябрь";
            else if (month == 12) monthTitle = "декабрь";
            else Console.WriteLine("Неверно введен номер месяца");
            if (monthTitle != "") Console.WriteLine($"Указанный месяц: {monthTitle}"); 
            #endregion

            Console.ReadKey();
        }
    }
}
