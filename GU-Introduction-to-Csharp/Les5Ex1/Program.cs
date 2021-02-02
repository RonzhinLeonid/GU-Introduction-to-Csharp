using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex1
{
    class Program
    {
        //Ронжин Л.
        //1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        static void Main(string[] args)
        {
            string filename = "text.txt";
            Console.WriteLine("Введите строку для записи в файл.");
            string str = Console.ReadLine();

            File.WriteAllText(filename, str);
        }
    }
}
