using System;
using System.Diagnostics;

namespace Les6Ex1
{
    class Program
    {
        //Ронжин Л.
        //Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс.
        //Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
        //В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
        static Process[] processes;
        static void Main(string[] args)
        {
            GetProcess();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Для закрытия процесса выберите команду:\n" +
                "KillProcForId - Закрытие процесса по его Id\n" +
                "KillProcForName - Закрытие процесса по его имени (регист не важен)\n" +
                "GetProcess - Обновить список процессов\n" +
                "Q - завершение работы");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "KillProcForId": KillProcForId(); break;
                    case "KillProcForName": KillProcForName(); break;
                    case "GetProcess": GetProcess(); break;
                }
                if (str == "Q")
                {
                    break;
                }
            }
        }
        /// <summary>
        /// Получение списка процессов
        /// </summary>
        private static void GetProcess()
        {
            processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                Console.WriteLine($"{item.Id,10} - {item.ProcessName}");
            }
        }
        /// <summary>
        /// Закрытие проекта по его Id
        /// </summary>
        static void KillProcForId()
        {
            Console.WriteLine("Введите id процесса");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in processes)
            {
                if (item.Id == id) item.Kill();
            }
        }
        /// <summary>
        /// Закрытие проекта по его имени
        /// </summary>
        static void KillProcForName()
        {
            Console.WriteLine("Введите имя процесса");
            string name = Console.ReadLine();
            foreach (var item in processes)
            {
                if (item.ProcessName.ToLower() == name.ToLower()) item.Kill();
            }
        }
    }
}
