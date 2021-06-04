using System;


namespace CorrectLogin
{
    internal class ChekLogin
    {
        /// <summary>Метод проверки на соответствие логина требованиям</summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        public static bool CheckLogin(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || LatinLetter.IsLatinLetter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }
    }
}