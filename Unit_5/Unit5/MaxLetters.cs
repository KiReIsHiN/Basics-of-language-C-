using System;
using System.Linq;
namespace TextCheck
{
    internal class MaxLetters
    {
        /// <summary>Считаем колличество букв в слове и выводим самое длинное</summary>
        /// <param name="Колличество букв">Считаем колличество букв</param>
        /// <returns></returns>
        public static void LettersMax()
        {
            int max = 0;
            string slovo = "";
            for (int i = 0; i < Message.words.GetLength(0); i++)
            {
                if (Message.words[i].Length > max)
                {
                    max = Message.words[i].Length;
                    slovo = Message.words[i];
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", slovo);

            Console.ReadKey();
        }
    }
}