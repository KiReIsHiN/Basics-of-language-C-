using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{

    /*
        Ввести вес и рост человека
        Рассчитать и вывести индекс массы тела (ИМТ) по формуле l=m/(h*h), где m - масса тела в кг, h-рост в метрах
    */

    class Program
    {
        static void Main(string[] args)
        {

            //создаем переменные роста, веса и индекса массы тела (l)
            double height;
            double weight;
            double l;

            Console.Write("Для рассчета индекса массы тела введите Ваши данные");
            Console.Write("\n_______\n");

            //Просим ввести роста
            Console.WriteLine("Введите Ваш рост (м):");
            //Считываем и записываем
            height = Convert.ToDouble(Console.ReadLine());

            //Просим ввести вес
            Console.WriteLine("Введите Ваш вес (кг):");

            //Считываем и записываем
            weight = Convert.ToDouble(Console.ReadLine());

            //Производим вычисление ИМТ по формуле 
            l = weight / (height * height);

            //Выводим итог на экран
            Console.WriteLine($"Ваш индекс массы тела = {l}.");
            //И немного юморим :)
            Console.WriteLine("Искренне надеемся, что эта информация осталась для Вас полезной! :)");

        }
    }
}
