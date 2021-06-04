using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * 2. Задание
 * Используя Windows Forms, разработать игру «Угадай число». 
 * Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
 * Компьютер говорит, больше или меньше загаданное число введенного.
 * Для ввода данных от человека используется элемент TextBox;
 */

namespace Guess_Number
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int insertNumber;
        public Random rand;
        public int randomNumber;
        public string numb;
        public int countTry;
        public int minStep;

        public MainWindow()
        {
            InitializeComponent();
            CheckNumber.Content = "Проверить";
            Header.Content = "Мы загадали число от 1 до 100. Попробуйте отгадать!";
            rand = new Random();
            InsertNumberbyPlayer.Text = string.Empty;
        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numb = InsertNumberbyPlayer.Text;
        }

        /// <summary>
        /// Кнопка новая игра. Загадываем число
        /// </summary>
        public void btnNewGame(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// Выйти из приложения
        /// </summary>
        public void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка проверки введенного числа
        /// </summary>
        public void CheckNumber_Check(object sender, RoutedEventArgs e)
        {
            insertNumber = Convert.ToInt32(numb);
            if (insertNumber < randomNumber)
            {
                MessageBox.Show("Вы ввели неверное число.Загаданное число больше");
                InsertNumberbyPlayer.Clear();
                countTry++;
                PlayerTry.Content = countTry;
            }
            else if (insertNumber > randomNumber)
            {
                MessageBox.Show("Вы ввели неверное число.Загаданное число меньше");
                InsertNumberbyPlayer.Clear();
                insertNumber = 0;
                countTry++;
                PlayerTry.Content = countTry;
            }

            if (insertNumber == randomNumber)
            {
                MessageBox.Show("Поздравляем. Вы угадали число!");
            }

            if(countTry > minStep)
            {
                MessageBox.Show("К сожалению, Вы превысили колличество попыток. Начните заново");
            }
        }

        /// <summary>
        /// Метод старта игры. Определение ранд числа
        /// </summary>
        public void NewGame()
        {
            MessageBox.Show("Мы загадали какое-то число. Отгадай его за меньшее количство шагов");
            randomNumber = rand.Next(1, 100);
            InsertNumberbyPlayer.Clear();
            
            if (randomNumber % 2 == 0)
            {
                minStep = randomNumber / 2;
            }
            else
            {
                minStep = (randomNumber - 1) / 2;
            }
            MinStepPlayer.Content = minStep;
        }




    }
}
