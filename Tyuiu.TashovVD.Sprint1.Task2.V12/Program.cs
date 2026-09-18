using Tyuiu.TashovVD.Sprint1.Task2.V12.Lib;

namespace Tyuiu.TashovVD.Sprint1.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y, z;

            Console.WriteLine("Введите длину параллелепипеда X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину параллелепипеда Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту параллелепипеда Z:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Объём параллелепипеда: ");
            Console.WriteLine(ds.CalculateParallelepipedVolume(x, y, z));
            Console.ReadKey();
        }
    }
}
