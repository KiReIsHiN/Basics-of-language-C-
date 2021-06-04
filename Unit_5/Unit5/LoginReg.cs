using System;
using System.Text.RegularExpressions;

namespace CorrectLogin
{
    internal class LoginReg

    {
        /// <summary>Метод проверки на соответствие логина требованиям через регулярные выражения</summary>
        /// <param name="login">Значение логина</param>
        /// <returns></returns>
        public static bool CheckLoginReg(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }
    }
}