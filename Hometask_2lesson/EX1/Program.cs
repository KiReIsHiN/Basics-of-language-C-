using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    //Написать метод, возвращающий минимальное из трех чисел   
    class Program
    {
        //Создаем три переменные и переменную минимального значения
        public static double a;
        public static double b;
        public static double c;
        public static double min;
        static void Main(string[] args)
        {
            //Просим ввести число 1
            Console.Write("Введите первое число: ");
            //Считываем и сохраняем в переменную а
            a = double.Parse(Console.ReadLine());

            //Просим ввести число 2
            Console.Write("Введите второе число: ");
            //Считываем и сохраняем в переменную б
            b = double.Parse(Console.ReadLine());

            //Просим ввести число 3
            Console.Write("Введите третье число: ");
            //Считываем и сохраняем в переменную с
            c = double.Parse(Console.ReadLine());

            //Запускаем метод подсчета минимального значения
            CalcMin();

            //Выводим на экран минимальное значение
            Console.Write ("Минимальное значение из предложенных = " + min);
            //Ждем дальнейших действий
            Console.ReadLine();
        }

        //Создаем метод для вычисления минимального значения
        public static void CalcMin()
        {
            if (a < b && a < c) //Если а меньше б и а меньше с
                min = a;  //Если да, то минимальное а
            else if(b < c)  //Если нет, а выкидываем и проверяем б меньше с?
                min =b;  //Если да, минимальное б
            else  //Если нет
                min = c;  //То минимальное с
        }
    }
}
