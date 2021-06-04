using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{

    /*
       Написать программу, которая подсчитывает расстояние между точками с координатами х1,у1 и х2,у2
       по формуле r= Math.Sqrt (Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)
       Вывести результат, используя спецификатор формата 2f (с двумя знаками после запятой)
    */

    class Program
    {
        static void Main(string[] args)
        {
            //Создаем переменные для точек координат
            Double x1 = 0;
            Double x2 = 0;
            Double y1 = 0;
            Double y2 = 0;
            Double distance;

            //Просим ввести значение для переменной
            Console.Write("Введите значение x1= ");
            //Считываем и записываем значение
            x1 = Convert.ToDouble(Console.ReadLine());

            //Просим ввести значение для переменной
            Console.Write("Введите значение x2= ");
            //Считываем и записываем значение
            x2 = Convert.ToDouble(Console.ReadLine());

            //Просим ввести значение для переменной
            Console.Write("Введите значение y1= ");
            //Считываем и записываем значение
            y1 = Convert.ToDouble(Console.ReadLine());

            //Просим ввести значение для переменной
            Console.Write("Введите значение y2= ");
            //Считываем и записываем значение
            y2 = Convert.ToDouble(Console.ReadLine());

            //Сделаем пробел для красоты
            Console.Write("\n\n```````````\n\n");

            //Подсчитываем расстояние по формуле и заносим данные в переменную
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Выводим значение в консоль
            Console.WriteLine("Расстояние между указанными координатами составляет: " + "{0:F}", distance);
            //Делаем паузу
            Console.ReadLine();

        }
    }
}
