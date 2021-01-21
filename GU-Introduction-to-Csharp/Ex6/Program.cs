using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        //Ронжин Л.
        //(*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру,
        //чтобы описать работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает
        //с понедельника до воскресенья.
        [Flags]
        enum dayWeek
        {
            Понедельник = 0b_0000001,
            Вторник     = 0b_0000010,
            Среда       = 0b_0000100,
            Четвег      = 0b_0001000,
            Пятница     = 0b_0010000,
            Суббота     = 0b_0100000,
            Воскресенье = 0b_1000000,
        }

        static dayWeek office1 = (dayWeek)0b0011111;
        static dayWeek office2 = (dayWeek)0b0110011;
        static dayWeek office3 = (dayWeek)0b0111110;
        static void Main(string[] args)
        {
            dayWeek dayWork = (dayWeek)DateTime.Now.DayOfWeek;
            Console.WriteLine($"Сегодня: {dayWork}");
            IsWorkOffice(dayWork);

            Console.Write("\nВведите номер дня который хотите проверить: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: dayWork = dayWeek.Понедельник; break;
                case 2: dayWork = dayWeek.Вторник; break;
                case 3: dayWork = dayWeek.Среда; break;
                case 4: dayWork = dayWeek.Четвег; break;
                case 5: dayWork = dayWeek.Пятница; break;
                case 6: dayWork = dayWeek.Суббота; break;
                case 7: dayWork = dayWeek.Воскресенье; break;
                default:
                    break;
            }
            Console.WriteLine($"Вы указали: {dayWork}");
            IsWorkOffice(dayWork);
            Console.ReadKey();
        }

        private static void IsWorkOffice(dayWeek day)
        {
            if ((day & office1) == day) Console.WriteLine("Работает office1");
            if ((day & office2) == day) Console.WriteLine("Работает office2");
            if ((day & office3) == day) Console.WriteLine("Работает office3");
        }
    }
}
