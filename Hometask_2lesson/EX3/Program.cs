﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    /*
        С клавиатуры вводятся числа, пока не будет введен 0. 
        Подсчитать сумму всех нечетных положительных чисел. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем переменную суммы
            double summa = 0;
            //Создаем переменную вводимого числа
            int number = 0;

            //Выводим задание и предполагаемый результат
            Console.WriteLine("Вводите поочередно числа. Когда будет введен ноль, будет выведена сумма нечетных чисел ");


            //Запускаем цикл do...while, так как хотя бы 1 число (нечетное, например) будет введено
            do
            {
                //Считываем и записываем в переменную вводимые числа
                number = int.Parse(Console.ReadLine());
                //Проверяем условие, что число больше нуля и является нечетным
                if (number > 0 && number % 2 == 1)
                //Если подходит по условиям, то плюсуем в переменную общей суммы
                    summa += number;

            } 
            //Делаем цикл до тех пор, пока не будет введен ноль
            while (number != 0);

            //Выводим в консоль сумму всех нечетных чисел
            Console.WriteLine("Сумма нечетных чисел равна: " + summa);
        }
    }
}