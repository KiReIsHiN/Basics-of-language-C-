using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.SumOfNum
{
    class SumOfNum
    {
        //Объявляем переменные
        public static int sum = 0;
        public static int num;

        //Создаем метод
        public static void SumNum(){

            //Дублируем задание
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введён 0 \n(каждое число в новой строке). \n Требуется подсчитать сумму всех нечётных положительных чисел.");


            //Вызываем цикл "делать ввод чисел, пока не будет введен ноль или буквы"
            do
            {
                //Просим ввести число
                Console.WriteLine("Введите число: ");
                //Используя трайпарс проверяем введен ли инт или нет
                bool f = int.TryParse(Console.ReadLine(),out num);
                //Если введен инт, число больше нуля и нечетное
                if (f==true && num > 0 && num % 2 == 1)
                    //Прибавляем его к переменной суммы
                    sum += num;

            } while (num != 0); //Делаем это, пока не получится ноль

            //Выводим сумму всех нечетных положительных чисел
            Console.WriteLine($"Cумма всех нечётных положительных чисел: " + sum);
        }
    }
}
