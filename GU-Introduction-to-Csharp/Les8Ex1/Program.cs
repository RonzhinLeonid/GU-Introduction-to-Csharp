using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Greeting))
                Console.WriteLine($"{Properties.Settings.Default.Greeting}!");

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserAge))
            {
                Console.WriteLine("Введите возраст пользователя:");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserCareer))
            {
                Console.WriteLine("Введите род деятельности:");
                Properties.Settings.Default.UserCareer = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            string userAge = Properties.Settings.Default.UserAge;
            string userCareer = Properties.Settings.Default.UserCareer;

            Console.WriteLine($"Имя: {userName}, возраст: {userAge}, род деятельности: {userCareer}.");
            Console.ReadKey();
        }
    }
}
