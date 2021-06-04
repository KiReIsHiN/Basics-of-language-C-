using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace EX5
{
    /*
        Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        Сделать задание, только вывод организовать в центре экрана.
     */
    class Program
    {
        public static string surname = "Kireishyn";
        public static string name = "Aliaksei";
        public static string city = "Minsk";


        static void SetConsWindow()
        {
            //Устанавливаем размер окна консоли
            Console.SetBufferSize(100, 50);
        }

        static void Main(string[] args)
        {
            //Пишем приветствие
            Console.WriteLine("Добрый день. Позвольте представиться. Я");

            //Устанавливаем курсор
            Console.SetCursorPosition(50, 10);
            //Пишем фамилию
            Console.WriteLine(surname);

            //Устанавливаем курсор
            Console.SetCursorPosition(50, 15);
            //Пишем имя
            Console.WriteLine(name);

            //Устанавливаем курсор
            Console.SetCursorPosition(50, 20);
            //Пишем город
            Console.WriteLine(city);
        }
    }
}
