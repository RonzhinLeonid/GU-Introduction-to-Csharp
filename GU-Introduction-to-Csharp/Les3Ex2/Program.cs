using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex2
{
    class Program
    {
        //Ронжин Л.
        //2. Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: 
        //первый элемент хранит имя контакта, второй — номер телефона/e-mail.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количство контактов");
            int n;
            do
            {
                if(int.TryParse(Console.ReadLine(), out n) )
                    break;
                else
                    Console.WriteLine("Данные некорректные, попробуйте еще раз.");
            } while (true);

            Random rnd = new Random();
            string[,] arr = new string[n, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i, 0] = $"Контакт №{i+1}";
                arr[i, 1] = rnd.Next(1000000, 9999999).ToString("###-##-##");
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i, 0]}. Номер телефона: {arr[i, 1]}\n");
            }

            Console.ReadKey();
        }
    }
}
