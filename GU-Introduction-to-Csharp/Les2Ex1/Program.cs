using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2Ex1
{
    class Program
    {
        //Ронжин Л.
        //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
        static void Main(string[] args)
        {
            Console.Write("Укажите минимальную температуру за сутки: ");
            int minT = int.Parse(Console.ReadLine());
            Console.Write("Укажите максимальную температуру за сутки: ");
            int maxT = int.Parse(Console.ReadLine());
            Console.WriteLine($"Среднесуточная температура равна: {(double)(maxT + minT)/2}");
            Console.ReadKey();
        }
    }
}
