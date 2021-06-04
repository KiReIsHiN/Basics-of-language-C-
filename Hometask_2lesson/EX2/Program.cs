using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    //Написать метод подсчета количества цифр числа

    class Program
    {
        static void Main(string[] args)
        {
            //Просим ввести число
            Console.Write("Введите Ваше число: ");
            //Выводим колличество знаков в числе с использованием отдельного метода
            Console.WriteLine("Количество знаков в данном числе составляет: " + count(Console.ReadLine()));
            //Ждем паузу
            Console.ReadKey();
        }

        //Отдельный метод для подсчета
        static int count(string s)
        {
            return s.Length;
        }
    }
}
