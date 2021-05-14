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
            int day = (int)DateTime.Now.DayOfWeek;
            dayWeek dayWork = SwitchDay(day);
            Console.WriteLine($"Сегодня: {dayWork}");
            if(!IsWorkOffice(dayWork)) Console.Write("Сегодня все офисы закрыты.");

            Console.Write("\nВведите номер дня который хотите проверить: ");
            day = int.Parse(Console.ReadLine());
            dayWork = SwitchDay(day);
            if (dayWork != 0)
            {
                Console.WriteLine($"Вы указали: {dayWork}");
                if (!IsWorkOffice(dayWork)) Console.Write("Сегодня все офисы закрыты.");
            }
            else Console.WriteLine($"Вы указали несуществующий день недели");
            Console.ReadKey();
        }

        private static dayWeek SwitchDay(int day)
        {
            switch (day)
            {
                case 1: return dayWeek.Понедельник;
                case 2: return dayWeek.Вторник; 
                case 3: return dayWeek.Среда;
                case 4: return dayWeek.Четвег; 
                case 5: return dayWeek.Пятница;
                case 6: return dayWeek.Суббота; 
                case 7: return dayWeek.Воскресенье;
                default: return 0;
            }
        }

        private static bool IsWorkOffice(dayWeek day)
        {
            bool temp =  false;
            if ((day & office1) == day) 
            { 
                Console.WriteLine("Работает office1");
                temp = true;
            }
            if ((day & office2) == day) 
            { 
                Console.WriteLine("Работает office2");
                temp = true;
            }
            if ((day & office3) == day) 
            {
                Console.WriteLine("Работает office3");
                temp = true;
            }
            return temp;
        }
    }
}
