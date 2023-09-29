using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint1.Task7.V18.Lib;

//Написать программу, которая вычисляет математическое выражение по исходным значениям данных,
//вводимых пользователем. Ответ округлите до 3 знаков после запятой.
//
//          1+sin^2(x+y)
// z = --------------------
//       |       2x     |
//   2 + | x- ----------|
//       |    1+x^2y^2  |

namespace Tyuiu.ZainagabdinovR.A.Sprint1.Task7.V18
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
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #1.7                                                            *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,                                                     *");
            Console.WriteLine("* которая вычисляет математическое выражение по исходным значениям данных *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("* Формула:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*         1+sin^2(x+y)                                                    *");
            Console.WriteLine("* z = --------------------                                                *");
            Console.WriteLine("*       |       2x     |                                                  *");
            Console.WriteLine("*   2 + | x- ----------|                                                  *");
            Console.WriteLine("*       |    1+x^2y^2  |                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*         1+sin^2(x+y)                                                    *");
            Console.WriteLine("* z = --------------------                                                *");
            Console.WriteLine("*       |       2x     |                                                  *");
            Console.WriteLine("*   2 + | x- ----------|                                                  *");
            Console.WriteLine("*       |    1+x^2y^2  |                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("ВВЕДИТЕ значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ВВЕДИТЕ значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
