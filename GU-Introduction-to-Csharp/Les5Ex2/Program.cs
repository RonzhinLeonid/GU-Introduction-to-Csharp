using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex2
{
    class Program
    {
        //Ронжин Л.
        //2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
        static void Main(string[] args)
        {
            WrireFile();
            WrireFile();
            WrireFile();
            WrireFile();
        }

        static void WrireFile()
        {
            string filename = "startup.txt";
            File.AppendAllText(filename, DateTime.Now.ToString("F") + "\n");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
