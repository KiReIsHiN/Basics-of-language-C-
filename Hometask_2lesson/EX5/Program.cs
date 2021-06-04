using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    /*
     * а) Написать программу, которая запрашивает массу и рост человека, 
     * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
     * Формула I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
     * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
     * Оптимальный вес вычисляется по формуле: Рост в см - 100
     */

    class Program
    {
        public static double hight; //Рост
        public static double weight; //Вес
        public static double imt; //Индекс Массы Тела 
        public static double requiredWeight; //Оптимальный вес
        public static double changeWeight; //Изменения в весе

        static void Main(string[] args)
        {
            //выводим общую информацию по ИМТ
            Console.WriteLine("ИМТ ( Индекс Массы Тела, кг/м2 ) Таблица категорий:");
            Console.WriteLine("Крайний недостаток веса - менее 16.5 ");
            Console.WriteLine("Недостаток в весе от 16.5 до 18.4 ");
            Console.WriteLine("Нормальный вес тела от 18.5 до 24.9");
            Console.WriteLine("Избыточная масса тела от 25 до 30");
            Console.WriteLine("Ожирение (Класс I) от 30.1 до 34.9");
            Console.WriteLine("Ожирение (Класс II - тяжелое) от 35 до 40 ");
            Console.WriteLine("Ожирение (Класс III - крайне тяжелое) более 40");

            //делаем красивый отступ
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            //Просим ввести рост в метрах
            Console.WriteLine("Введите Ваш рост в метрах через заяптую: ");
            //Считываем и сохраняем в переменную
            double hight = double.Parse(Console.ReadLine());

            //Просим ввести вес в кг
            Console.WriteLine("Введите Ваш вес (в кг): ");
            //Считываем и сохраняем в переменную
            double weight = double.Parse(Console.ReadLine());

            //Высчитываем ИМТ
            imt = weight / (hight * hight);

            //Выводим ИМТ
            Console.WriteLine("Ваш ИМТ составляет: {0:F2}", imt);
            Console.WriteLine("Нажмите Enter для получения более подробной информации");
            Console.ReadLine();

            //Сверяем, что нужно сделать: набрать, норма или сбросить
            if (imt <= 18.4)
            {
                //Пишем рекомендации
                Console.WriteLine("Вам необходимо набрать вес");
                //Высчитываем оптимальный вес по формуле "рост в см - 100"
                requiredWeight = hight * 100 - 100;
                //Выводим оптимальный вес
                Console.WriteLine("Ваш оптимальный вес: " + requiredWeight);
                //Высчитываем разницу
                changeWeight = requiredWeight - weight;
                //Пишем, сколько нужно набрать
                Console.WriteLine("Вам нужно набрать (кг): " + changeWeight);
                Console.ReadLine();
            }
            else if (imt >= 18.5 && imt <= 24.9)
            {
                Console.WriteLine("У Вас нормальный вес");
                Console.ReadLine();
            }
            else
            {
                //Пишем рекомендации
                Console.WriteLine("Вам необходимо похудеть");
                //Высчитываем оптимальный вес по формуле "рост в см - 100"
                requiredWeight = hight * 100 - 100;
                //Выводим оптимальный вес
                Console.WriteLine("Ваш оптимальный вес: " + requiredWeight);
                //Высчитываем разницу
                changeWeight = weight - requiredWeight;
                //Пишем, сколько нужно сбросить
                Console.WriteLine("Вам нужно сбросить (кг): " + changeWeight);
                Console.ReadLine();
            }
        }
    }
}
