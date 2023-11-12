using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint4.Task6.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 4                                                                  *");
            Console.WriteLine("*Тема: Класс Array.                                                        *");
            Console.WriteLine("*Задание #6                                                                *");
            Console.WriteLine("*Вариант #19                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дан строковый массив данных [Chrome, Firefox, Safari, Opera, Edge,       *");
            Console.WriteLine("* Internet Explorer, Brave] используя класс Array подсчитайте  количество  *");
            Console.WriteLine("* элементов, длина которых больше 5.                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            var browse = new string[] { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < browse.Length - 1; i++)
            {
                Console.WriteLine(browse[i]);
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Число элементов дляна которых больше 5");
            int nums = ds.Calculate(browse);
            Console.WriteLine(nums);

            Console.ReadKey();
        }
    }
}
