﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint3.Task0.V27.Lib;


namespace Tyuiu.CherepanovVS.Sprint3.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт4                                                                   *");
            Console.WriteLine("*Тема: Одномерные массивы (статический ввод)                               *");
            Console.WriteLine("*Задание #0                                                                *");
            Console.WriteLine("*Вариант #27                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение    *");
            Console.WriteLine("* нечетных элементов массива. {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length-1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива = " + ds.GetMultOddArrEl(numsArray));
            Console.ReadLine();
        }
    }
}
