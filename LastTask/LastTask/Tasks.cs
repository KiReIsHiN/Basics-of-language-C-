using System;

namespace LastTask
{
    class Tasks:Program
    {
        public void Task()
        {
            Console.WriteLine("Приветствую Вас на последнем домашнем задании");
            Console.WriteLine("Выберите интересующее Вас задание. Для этого укажите номер");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Задание 1 : С помощью рефлексии выведите все свойства структуры DateTime");
            Console.WriteLine("Задание 2 : Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.");
            Console.WriteLine("Задание 3 : Работа с приложением 'Верю-Неверю'");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    ShowDataTime dt = new ShowDataTime();
                    dt.DTShow();
                    break;
                case 2:
                    ProgramForm pf = new ProgramForm();
                    pf.Start();
                    break;
                case 3:
                    BelieveOrNotBelieve bnb = new BelieveOrNotBelieve();
                    bnb.Start();
                    break;
                default:
                    Console.WriteLine("Извините, но такого задания нет :)");
                    break;
            }
        }
    }
}
