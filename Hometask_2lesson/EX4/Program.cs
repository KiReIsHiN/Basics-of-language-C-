using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    /*
     * Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. 
     * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
     * (Логин: root, Password: GeekBrains). 
     * Используя метод проверки логина и пароля, написать программу: 
     * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
     * С помощью цикла do while ограничить ввод пароля тремя попытками.
     */


    class Program
    {
        //Создаем переменную логина
        public static string login = "root";
        //Создаем переменную логина
        public static string password = "GeekBrains";
        //Создаем переменную вводимого логина 
        public static string insertLogin;
        //Создаем переменную вводимого пароля
        public static string insertPassword;
        //Создаем переменную колличества попыток входа
        public static int count = 0;


        public static void Main(string[] args)
        {
            //Запускаем цикл проверки колличества вводов (максимально 3)
            //В нем вложен основной код, где вводят логин и пароль и проверяют соответствие
            do
            {
                //Просим ввести логин
                Console.WriteLine("\nВведите логин: ");
                //Считываем введенный логин
                string insertLogin = Console.ReadLine();

                //Просим ввести пароль
                Console.WriteLine("Введите пароль: ");
                //Считываем введенный пароль
                string insertPassword = Console.ReadLine();

                //Проверяем совпал ли логин и пароль
                if (login == insertLogin && password == insertPassword)
                {
                    //Если совпал, то пускаем дальше
                    Console.WriteLine("Добро пожаловать");
                    //Делаем паузу
                    Console.ReadLine();
                    break;
                }
                //Если нет, то просим ввести заново
                Console.WriteLine("Неверно введен логин или пароль. Попробуйте заново");
                //Делаем паузу
                Console.ReadLine();
                //Добавляем к счетчику +1 попытку
                ++count;
            } while (count < 3);
        }
    }
}
