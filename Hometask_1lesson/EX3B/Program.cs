using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B
{

    /*
    Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    Выполнить задание, оформив вычисления расстояния между точками в виде метода.
     */

    class Program
    {
        //Создаем переменные для точек координат
        public static Double x1 = 0;
        public static Double x2 = 0;
        public static Double y1 = 0;
        public static Double y2 = 0;
        public static Double distance;

        static void Main(string[] args)
        {
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

            Calc();

            //Выводим значение в консоль
            Console.WriteLine("Расстояние между указанными координатами составляет: " + "{0:F}", distance);
            //Делаем паузу
            Console.ReadLine();
        }

        //Создаем отдельный метод для расчета расстояния
        static void Calc()
        {
            //Подсчитываем расстояние по формуле и заносим данные в переменную
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
