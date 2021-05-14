using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;

namespace Les5Ex5
{
    class Program
    {
        //Ронжин Л.
        //5.(*) Список задач (ToDo-list):
        // - написать приложение для ввода списка задач;
        // - задачу описать классом ToDo с полями Title и IsDone;
        // - на старте, если есть файл tasks.json/xml/bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
        // - если задача выполнена, вывести перед её названием строку «[x]»;
        // - вывести порядковый номер для каждой задачи;
        // - при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
        // - записать актуальный массив задач в файл tasks.json/xml/bin.

        static List<ToDoList> listTask;
        static void Main(string[] args)
        {
            string filaName = "toDoList.json";

            bool t = File.Exists(filaName);

            listTask = new List<ToDoList>();

            string json = File.ReadAllText(filaName);

            //ToDoList listTask11 = JsonSerializer.Deserialize<ToDoList>(json, new JsonSerializerOptions() { WriteIndented = true });
            listTask = JsonSerializer.Deserialize<List<ToDoList>>(json);


            listTask.Add(new ToDoList("dhdh", true));
            listTask.Add(new ToDoList("dh23dh", false));
            listTask.Add(new ToDoList("dh2dh", true));
            listTask.Add(new ToDoList("d44hdh", false));

            string json1 =  JsonSerializer.Serialize(listTask,new JsonSerializerOptions() { WriteIndented = true});
            File.WriteAllText(filaName, json1);

              

            
           // AddTask();
           // ChangeStatus();
            Console.ReadKey();
        }
        static public ToDoList AddTask()
        {
            Console.WriteLine("Введите название задачи.");
            return new ToDoList(Console.ReadLine(), false);
        }
        static public void ChangeStatus()
        {
            Console.WriteLine("Введите номер задачи.");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < listTask.Count; i++)
            {
                if (listTask[i].Number == num) listTask[i].IsDone = true;
            }
        }
        static public void LoadJson()
        { }
        static public void ReadJson()
        { }
    }
}