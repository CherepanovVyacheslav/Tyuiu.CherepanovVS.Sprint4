using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint4.Task2.V8.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 4                                                                  *");
            Console.WriteLine("*Тема: Одномерные массивы (генератор случайных чисел).                     *");
            Console.WriteLine("*Задание #2                                                                *");
            Console.WriteLine("*Вариант #8                                                                *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный          *");
            Console.WriteLine("* случайными значениями в диапазоне от 2 до 7, подсчитать сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int len;
            Console.WriteLine("Введите колличество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                numsArray[i] = rnd.Next(2,7);

            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма нечетных элементов массива = " + ds.Calculate(numsArray));
            Console.ReadLine();
        }
    }
}
