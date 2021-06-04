using System;
using Structures.ComplStruct;

namespace Methods.ComplexNumbers
{
    class ComplexNumbers
    {

        //Создаем метод вычитания комплексных чисел
        public static ComplStruct.Complex ComplexMinus(ComplStruct.Complex firstNumber, ComplStruct.Complex secondNumber)
        {
            //Заводим новое комплексное число
            ComplStruct.Complex result = new ComplStruct.Complex();
            //Действительная часть первого минус действительная часть второго
            result.re = firstNumber.re - secondNumber.re;
            //Мнимая часть первого минус мнимая часть второго
            result.im = firstNumber.im - secondNumber.im;
            //Возвращаем результат
            return result;
        }


        //Создаем метод умножения комплексных чисел
        public static ComplStruct.Complex MultByComplex(ComplStruct.Complex firstNumber, ComplStruct.Complex secondNumber)
        {
            //Заводим новое комплексное число
            ComplStruct.Complex resMult = new ComplStruct.Complex();
            //Вычисляем действительную часть числа
            resMult.re = firstNumber.re * secondNumber.re - firstNumber.im * secondNumber.im;
            //Вычисляем мнимую часть числа
            resMult.im = firstNumber.re * secondNumber.im + firstNumber.im * secondNumber.re;
            //Возвращаем результат
            return resMult;
        }



        public static void ComplNum()
        {
            //Выводим в консоль первое комплексное число
            Console.Write("Первое комплексное число: ");
            ComplStruct.Complex z1 = new ComplStruct.Complex(re: 44, im: 99);
            z1.Print();
            //Выводим в консоль второе комплексное число
            Console.Write("Второе комплексное число: ");
            ComplStruct.Complex z2 = new ComplStruct.Complex(150, 700);
            z2.Print();

            //Делаем переключатель для подпунктов а и б
            Console.WriteLine("Нажмите A или B для проверки вычитания и умножения комплексных чисел");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "A":
                    //Вызываем метод вычитания комплексных чисел и помещаем его результат в переменную
                    Console.Write("Результат вычитания комплексных чисел: ");
                    ComplStruct.Complex z3 = ComplexMinus(z1,z2);
                    z3.Print();
                    break;

                case "B":
                    //Вызываем метод умножения комплексных чисел и помещаем его результат в переменную
                    Console.Write("Результат произведения комплексных чисел: ");
                    ComplStruct.Complex z4 = MultByComplex(z1, z2);
                    z4.Print();
                    break;

                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }
        }
    }
}
