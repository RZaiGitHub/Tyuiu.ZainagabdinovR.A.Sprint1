using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint1.Task3.V6.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #1.3                                                            *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Расчеты:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно).Исходными данными являются: расстояние до дачи(км);    *");
            Console.WriteLine("* количество бензина, которое потребляет автомобиль на 100 км пробега;    *");
            Console.WriteLine("* цена одного литра бензина.                                              *");

            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;

            Console.WriteLine("* Расстояние до дачи(км) = " + distance);
            Console.WriteLine("* Расход бензина(литров на 100 км пробега) = " + gasFlow);
            Console.WriteLine("* Цена литра бензина(руб.) = " + gasPrice);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Поездка на дачу и обратно обойдется в " + ds.TravelCost(distance, gasFlow, gasPrice));

            Console.ReadKey();

        }
    }
}
