using System;
using System.Linq;
namespace TextCheck
{
    internal class LishniSimvol
    {
        /// <summary>Указываем символ, слова с которым убираем</summary>
        /// <param name="Лишний символ">Убираем слова с символом</param>
        /// <returns></returns>
        public static void WrongSymbol()
        {
            Console.WriteLine("Укажите символ, слова с которым не должны быть показаны");
            Message.symbol = Console.ReadLine()[0];

            Console.WriteLine("Вывод только тех слов сообщения, которые не содержат указанный символ");
            Console.WriteLine(String.Join(" ", Message.text.Split().Where(x => x[x.Length - 1] != Message.symbol)));
        }
    }
}