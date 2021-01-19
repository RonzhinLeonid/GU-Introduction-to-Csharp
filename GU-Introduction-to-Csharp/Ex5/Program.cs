using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        //Ронжин Л.
        //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»
        static void Main(string[] args)
        {
            Console.Write("Укажите минимальную температуру за сутки: ");
            int minT = int.Parse(Console.ReadLine());
            Console.Write("Укажите максимальную температуру за сутки: ");
            int maxT = int.Parse(Console.ReadLine());

            double averageDailyT = (double)(maxT + minT) / 2;
            Console.Write("Укажите порядковый номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            string season = "";
            #region switch
            switch (month)
            {
                case 1: 
                case 2: 
                case 12: season = "зима"; break;
                case 3: 
                case 4: 
                case 5: season = "весна"; break;
                case 6: 
                case 7: 
                case 8: season = "лето"; break;
                case 9: 
                case 10: 
                case 11: season = "осень"; break;
                default: Console.WriteLine("Неверно введен номер месяца"); break;
            }
            #endregion
            if (season != "")
            {
                if (season == "зима" && averageDailyT > 0)
                    Console.WriteLine("Дождливая зима.");
                else
                    Console.WriteLine($"Среднесуточная температура равна: {averageDailyT}. Текущее время года: {season}");
            }

            Console.ReadKey();
        }
    }
}
