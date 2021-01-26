using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex1
{
    //Ронжин Л.
    //1. Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в 
    //разных аргументах и возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
    class Program
    {
        static void Main(string[] args)
        {
            string[,] fullName = new string[4, 3];
            SetFullName(ref fullName);

            for (int i = 0; i < fullName.GetLength(0); i++)
            {
                Console.WriteLine($"{GetFullName(fullName[i,0], fullName[i, 1], fullName[i, 2])}");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Объединение ФИО в одну строку
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns></returns>
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
        /// <summary>
        /// Объединение ФИО в одну строку через params
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static string GetFullNameParams(params string[] values)
        {
            string temp = "";
            for (int i = 0; i < values.Length; i++)
            {
                temp += values[i] + " ";
            }
            return temp;
        }
        /// <summary>
        /// Заполнение массива fullName значениями через ref
        /// </summary>
        /// <param name="fullName"></param>
        static void SetFullName(ref string[,] fullName)
        {
            for (int i = 0; i < fullName.GetLength(0); i++)
            {
                fullName[i, 0] = "FirstName" + (i + 1);
                fullName[i, 1] = "LastName" + (i + 1);
                fullName[i, 2] = "Patronymic" + (i + 1);
            }
        }
    }
}
