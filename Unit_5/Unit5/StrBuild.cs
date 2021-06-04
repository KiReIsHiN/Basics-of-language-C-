using System;
using System.Text;
using System.Linq;

namespace TextCheck
{
    internal class StrBuild
    {
        /// <summary>Из длинных слов формируем строку</summary>
        /// <param name="Длинные слова">Строка с длинными словами</param>
        /// <returns></returns>

        public static void StringBuild ()
        {
            Console.WriteLine("Строка из самых длинных слов сообщения: " + String.Join(" ", Message.text.Split(' ').Where(n => n.Length == Message.text.Split(' ').Max(l => l.Length))));
        }


    }
}