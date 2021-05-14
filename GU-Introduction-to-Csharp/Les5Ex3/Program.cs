using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex3
{
    class Program
    {
        //Ронжин Л.
        //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        static void Main(string[] args)
        {

            byte[] array = new byte[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToByte(Console.ReadLine());
            }
            File.WriteAllBytes("bytes.bin", array);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");
            Console.ReadKey();
        }
    }
}
