using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3Ex4
{
    class Program
    {
        //Ронжин Л.
        //4. * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
        static void Main(string[] args)
        {
            int[,] arrShip = {  { 2, 1, 4, 5, 1, 2, 9, 9, 9, 9, 7, 8, 9, 0, 0, 0, 5, 5, 5, 5},
                                { 6, 3, 7, 9, 0, 0, 0, 1, 8, 9, 3, 3, 3, 7, 8, 9, 1, 2, 3, 4} };
            string[,] map = new string[10, 10];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    for (int k = 0; k < arrShip.GetLength(1); k++)
                    {
                        if (arrShip[0, k] == i && arrShip[1, k] == j)
                        {
                            map[i, j] = "Х";
                        }
                    }
                    if (map[i, j] != "Х") map[i, j] = "O";
                }
            }
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "Х")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{map[i, j]} ");
                        Console.ResetColor();
                    }    
                    else
                        Console.Write($"{map[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
