using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    /*
     * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
     */

    class Program
    {
        public static int firstNumber;
        public static int lastNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            lastNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Все числа из указанного промежутка: ");
            Loop(firstNumber, lastNumber);
            Console.ReadLine();
        }

        public static void Loop (int firstNumber, int lastNumber)
        {
            Console.Write("{0,4}", firstNumber);
            if (firstNumber < lastNumber)
                Loop(firstNumber + 1, lastNumber);
        }
    }
}
