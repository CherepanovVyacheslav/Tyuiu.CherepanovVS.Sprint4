using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint4.Task7.V7.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 4                                                                  *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту.                  *");
            Console.WriteLine("*Задание #7                                                                *");
            Console.WriteLine("*Вариант #7                                                                *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 31415926. Преобразуйте ее в матрицу 4  *");
            Console.WriteLine("* на 2 и подсчитайте количество нечетных чисел в матрице.                  *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "31415926";
            int index = 0;
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Количество нечетных элементов матрицы:");
            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}        

