using System;
using System.Linq;
namespace TextCheck
{
    internal class Nletter
    {
        /// <summary>Указываем количество букв в слове</summary>
        /// <param name="Максимальное количество букв">Убираем слова с большим колличеством букв</param>
        /// <returns></returns>
        public static void Nletters()
        {
            Console.WriteLine("Какое максимальное колличество букв должно быть в слове?");
            Message.letterNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Вывод только тех слов сообщения, которые содержат не более указанного колличества");
            Console.WriteLine(String.Join(" ", Message.text.Split().Where(x => x.Length <= Message.letterNumber)));
        }
    }
}