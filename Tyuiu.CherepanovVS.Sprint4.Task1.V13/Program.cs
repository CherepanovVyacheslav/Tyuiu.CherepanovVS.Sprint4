using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint4.Task1.V13.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 4                                                                  *");
            Console.WriteLine("*Тема: Одномерные массивы. (ввод с клавиатуры)                             *");
            Console.WriteLine("*Задание #1                                                                *");
            Console.WriteLine("*Вариант #13                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 8 подсчитать сумму четных    *");
            Console.WriteLine("* элементов массива.  С клавиатуры: 8, 1, 5, 4, 2, 1, 2, 7, 6, 1           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int len;
            Console.WriteLine("Введите колличество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray= new int[len];
            
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Сумма четных элементов массива = " + ds.Calculate(numsArray));
            Console.ReadLine();
        }
    }
}
