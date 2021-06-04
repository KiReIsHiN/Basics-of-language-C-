using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4B
{
    /*
        Написать программу обмена значениями двух переменных типа int 
        без использования вспомогательных методов.
        без использованием третьей переменной; 
     */

    class Program
    {
        //Создаем три переменные
        public static double firstNumber;
        public static double secondNumber;

        static void Main(string[] args)
        {

            //Просим ввести значение 1 переменной
            Console.Write("Введите значение 1: ");
            //Считываем введенное значение
            firstNumber = Convert.ToDouble(Console.ReadLine());

            //Просим ввести значение 2 переменной
            Console.Write("Введите значение 2: ");
            //Считываем введенное значение
            secondNumber = Convert.ToDouble(Console.ReadLine());


            /*
                Меняем значения двух переменных без третьей по схеме:
                a = a + b;
                b = b - a;
                b = -b;
                a = a - b;
            */
            firstNumber = firstNumber + secondNumber;
            secondNumber = secondNumber - firstNumber;
            secondNumber = -secondNumber;
            firstNumber = firstNumber - secondNumber;

            //Делаем красивый отступ и юмористическую вставку
            Console.WriteLine("\n`````");
            Console.WriteLine("Пара хитрых махинаций и ....");
            Console.WriteLine("\n`````");

            //Выводим измененные значения в консоль
            Console.WriteLine("Значение 1 изменено на: " + firstNumber);
            Console.WriteLine("Значение 2 изменено на: " + secondNumber);

        }
    }
}
