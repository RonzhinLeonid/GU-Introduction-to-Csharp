using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex4
{
    class Program
    {
        //Ронжин Л.
        //(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
        static void Main(string[] args)
        {
            string directoryName = @"E:\ЛИСП";
            GetRecursFiles(directoryName);
            Console.ReadKey();
        }
        static void GetRecursFiles(string start_path)
        {
            string file = "text.txt";
            string[] folders = Directory.GetDirectories(start_path);
            foreach (string folder in folders)
            {
                File.AppendAllText(file, "Папка: " + folder + "\n");
                GetRecursFiles(folder);
            }
            string[] files = Directory.GetFiles(start_path);
            foreach (string filename in files)
            {
                File.AppendAllText(file, "Файл: " + filename + "\n");
            }
        }
    }
}
