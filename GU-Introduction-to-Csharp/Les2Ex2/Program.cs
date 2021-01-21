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
        enum Month
        {
            январь = 1,
            февраль,
            март,
            апрель,
            май,
            июнь,
            июль,
            август,
            сентябрь,
            октябрь,
            ноябрь,
            декабрь
        }

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

            #region enum
            monthTitle = "";
            switch (month)
            {
                case (int)Month.январь: monthTitle = "январь"; break;
                case (int)Month.февраль: monthTitle = "февраль"; break;
                case (int)Month.март: monthTitle = "март"; break;
                case (int)Month.апрель: monthTitle = "апрель"; break;
                case (int)Month.май: monthTitle = "май"; break;
                case (int)Month.июнь: monthTitle = "июнь"; break;
                case (int)Month.июль: monthTitle = "июль"; break;
                case (int)Month.август: monthTitle = "август"; break;
                case (int)Month.сентябрь: monthTitle = "сентябрь"; break;
                case (int)Month.октябрь: monthTitle = "октябрь"; break;
                case (int)Month.ноябрь: monthTitle = "ноябрь"; break;
                case (int)Month.декабрь: monthTitle = "декабрь"; break;
                default: Console.WriteLine("Неверно введен номер месяца"); break;
            }
            if (monthTitle != "") Console.WriteLine($"Указанный месяц: {monthTitle}");
            #endregion

            Console.ReadKey();
        }
    }
}
