using System;


namespace TextCheck
{
    /// <summary>Код для запуска решения задачи 2</summary>
    /// <param name="x">Чтение текста по заданным параметрам</param>
    /// <returns></returns>
    class Message
    {
        public static string text;  //Предложение
        public static int letterNumber;//Колличество букв в слове
        public static char symbol;//Символ, с которым нельзя показывать слова
        public static string[] words;

        public static void Start ()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Вас приветствует программа обработки текста. Введите предложение");
            text = Console.ReadLine();
            words = text.Split(new char[] { ' ', ',', '.', '!', '?' });
            

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

            Nletter.Nletters(); //Вывод слов с указанным максимальным колличеством букв
            Console.ReadLine();
            LishniSimvol.WrongSymbol();//Слова без указанного символа
            Console.ReadLine();
            MaxLetters.LettersMax();//Слово с максимальным колличеством букв
            Console.ReadLine();
            StrBuild.StringBuild();
        }
    }
}
