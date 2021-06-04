using System;
using System.IO;


namespace Basic
{
    class CheckLogin
    {
        string path = @"Db.txt"; //Путь к файлу с бд
        string[,] db; //Создаем массив стрингов с логином и паролем

        public void Start()
        {
            //Проверяем, есть ли файл
            if (File.Exists(path))
            {
                db = File.ReadAllLines(path);
            }else 
            {
                //Если файд не найден, то пишем, что файл не нашли
                Console.WriteLine("File with login and password could not be found");

            }
        }
    }
}
