using Tyuiu.TashovVD.Sprint1.Task7.V18.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите      *");
            Console.WriteLine("* до 3 знаков после запятой.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*           1 + sin^2(x + y)                                              *");
            Console.WriteLine("* z = --------------------------- + x                                     *");
            Console.WriteLine("*          |        2x       |                                            *");
            Console.WriteLine("*      2 + |x - -------------|                                            *");
            Console.WriteLine("*          |     1 + x^2*y^2 |                                            *");
            double x, y;
            Console.Write("Введите знчение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знчение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double res = ds.Calculate(x, y);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
