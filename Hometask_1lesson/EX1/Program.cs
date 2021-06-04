using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    /*
        Написать программу "Анкета":
        Последовательно задать вопросы (имя, фамилия, возраст, рост, вес)
        В результате вывести всю информаци в одну строку:
            a)используя склеивание
            b)используя форматированный вывод
            c)используя вывод со знаком $ (интерполяция)
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Устанавливаем переменные Имя, Фамилия, возраст,рост,вес 
            string name;
            string surname;
            string age;
            string heigh;
            string weight;

            //Выводим инструкцию ввода имени
            Console.WriteLine("Укажите Ваше имя и нажмите Enter:");
            //Считываем введенные данные и записываем в переменную
            name = Console.ReadLine();

            //Выводим инструкцию ввода фамилии    
            Console.WriteLine("Укажите Вашу фамилию и нажмите Enter:");
            //Считываем введенные данные и записываем в переменную
            surname = Console.ReadLine();

            //Выводим инструкцию ввода возраста
            Console.WriteLine("Укажите Ваш возраст и нажмите Enter:");
            //Считываем введенные данные и записываем в переменную
            age = Console.ReadLine();

            //Выводим инструкцию ввода роста
            Console.WriteLine("Укажите Ваш рост и нажмите Enter:");
            //Считываем введенные данные и записываем в переменную
            heigh = Console.ReadLine();

            //Выводим инструкцию ввода веса
            Console.WriteLine("Укажите Ваш вес и нажмите Enter:");
            //Считываем введенные данные и записываем в переменную
            weight = Console.ReadLine();

            //Делаем отступ несколько строк для лучшего визуального отображения
            Console.WriteLine("\n\n\n\n\n");

            //Выводим анкету в одну строку путем склейки 
            Console.WriteLine("Имя: " + name + "," + "Фамилия: " + surname + "," + "Возраст: " + age + "," + "Рост: " + heigh + "," + "Вес: " + weight);
            //Выводим анкету в одну строку форматированным выводом
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name, surname, age, heigh, weight);
            //Выводим анкету со знаком $ (интерполяция)
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {heigh}, Вес: {weight}");

        }
    }
}
