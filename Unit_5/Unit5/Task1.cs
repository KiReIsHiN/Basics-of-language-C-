using System;

namespace CorrectLogin
{
    /// <summary>Код для запуска решения задачи 1</summary>
    /// <param name="x">Проверка корректности ввода логина</param>
    /// <returns></returns>
    internal class Task1
    {
        public static void Start ()
        {
            Console.WriteLine("Вас приветствует программа проверки корректности логина.");
            int AmountOfTries = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (ChekLogin.CheckLogin(login) && LoginReg.CheckLoginReg(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    AmountOfTries--;
                    Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой."
                        + Environment.NewLine + "У Вас осталось " + AmountOfTries + TryWord.RightTryWord(AmountOfTries));
                }

            } while (AmountOfTries > 0);

            Console.WriteLine("Логин корректен!");

            Console.ReadKey();
        }
    }
}