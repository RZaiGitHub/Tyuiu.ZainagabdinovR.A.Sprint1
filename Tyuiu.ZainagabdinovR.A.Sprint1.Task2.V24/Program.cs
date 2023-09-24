using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint1.Task2.V24.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint1.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #1.2                                                            *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");

            int x;
            int y;

            Console.WriteLine("ВВЕДИТЕ значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ВВЕДИТЕ значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Формулировка задания: Заданы два числа.Вычислить квадрат их разницы.    *");
            Console.WriteLine("* Что пользователь вводит? Первое число(целое число),                     *");
            Console.WriteLine("* Второе число(целое число) Что программа печатает на экране?             *");
            Console.WriteLine("* Квадрат разницы(целое число)                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateDiffSquare(x, y));

            Console.ReadKey();

        }
    }
}
