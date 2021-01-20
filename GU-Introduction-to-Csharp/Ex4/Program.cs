using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        //Ронжин Л.
        //Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
        //только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, 
        //которые были заранее заготовлены до вывода на консоль.
        static void Main(string[] args)
        {
            int numberSales = 2510;
            string nameShop = "Ромашка";
            string nameCashier = "Иванов И.И";
            string[] products = new string[] { "Товар 1", "Товар 2", "Товар 3", "Товар 4" };
            int[] quantity = new int[] { 1, 3, 2, 1 };
            decimal[] cost = new decimal[] { 1000, 2000, 1500, 1300 };
            decimal total = 0;

            Console.WriteLine("      Кассовый чек");
            Console.WriteLine($"{nameShop,15}"); 
            Console.WriteLine($"Чек {numberSales,18}");
            Console.WriteLine($"{DateTime.Now:dd.MM.yy HH:mm}");
            Console.WriteLine($"Кассир {nameCashier,15}");
            Console.WriteLine();
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i+1}. {products[i]}");
                Console.WriteLine($"{quantity[i],4} * {cost[i]} = {quantity[i] * cost[i],8}");
                total += quantity[i] * cost[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Итого:{total,16}");
            Console.ReadKey();
        }
    }
}
