using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace Les5Ex5Core
{
    class Program
    {
        static List<ToDoList> listTask;
        static string filaName = "toDoList.json";
        static void Main(string[] args)
        {

            if (File.Exists(filaName))
            {
                ReadJson();
                PrintToDoList();
            }
            else
            {
                Console.WriteLine("Файла со списком дел нет.");
                listTask = new List<ToDoList>();
                AddTask();
            }

            while (true)
            {
                Console.WriteLine("Выберите действие.\n" +
                    "Add - Добавить дело\n" +
                    "Print - Вывести список дел наэкран\n" +
                    "Change - Сменить статус\n" +
                    "Q - Для прекращения работы\n");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "Add": AddTask(); PrintToDoList(); break;
                    case "Print": PrintToDoList(); break;
                    case "Change": ChangeStatus(); PrintToDoList(); break;
                }
                if (str == "Q")
                {
                    WriteJson();
                    break;
                }
                
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Добавить задачу
        /// </summary>
        static public void AddTask()
        {
            Console.WriteLine("Введите название задачи.");
            listTask.Add(new ToDoList(Console.ReadLine(), false));
        }
        /// <summary>
        /// Сменить статус задачи по номеру
        /// </summary>
        static public void ChangeStatus()
        {
            bool temp = false;
            Console.WriteLine("Введите номер задачи.");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < listTask.Count; i++)
            {
                if (listTask[i].Number == num)
                { 
                    listTask[i].IsDone = true;
                    temp = true;
                }
            }
            if (!temp)
            {
                Console.WriteLine("Задачи с указанным номером нет.");
            }
        }
        /// <summary>
        /// Записать в json файл
        /// </summary>
        static public void WriteJson()
        {
            string json1 = JsonSerializer.Serialize(listTask, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(filaName, json1);
        }
        /// <summary>
        /// Считать json файл
        /// </summary>
        static public void ReadJson()
        {
            string json = File.ReadAllText(filaName);
            listTask = JsonSerializer.Deserialize<List<ToDoList>>(json);
        }
        /// <summary>
        /// Вывесть список дел на экран
        /// </summary>
        static public void PrintToDoList()
        {
            for (int i = 0; i < listTask.Count; i++)
            {
                Console.WriteLine(listTask[i].ToString());
            }
        }
    }
}
