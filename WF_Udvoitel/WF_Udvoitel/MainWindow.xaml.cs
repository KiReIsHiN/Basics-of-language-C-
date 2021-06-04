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


/*1. Задание
    а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
    в) Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
        Вся логика игры должна быть реализована в классе с удвоителем.

    Кирейшин Алексей
*/


namespace WF_Udvoitel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public Random r;
        public int count;
        public int randomNumber;
        public Stack<string> history = new Stack<string>();

        public MainWindow()
        {
            InitializeComponent();
            btnCommand1.Content = "+1";
            btnCommand2.Content = "x2";
            btnReset.Content = "Сброс";
            lblNumber.Content = "0";
            this.Title = "Удвоитель";
            r = new Random();
        }

        /// <summary>
        /// Функция очистки данных
        /// </summary>
        public void Reset()
        {
            lblNumber.Content = "0";
            count = 0;
            lblCount.Content = count;
        }

        /// <summary>
        /// Кнопка новая игра
        /// </summary>
        public void btnNewGame(object sender, RoutedEventArgs e)
        {
            randomNumber = r.Next(5, 100);
            MessageBox.Show($"Получить число {randomNumber} за меньшее количество ходов");
            Reset();
        }


        /// <summary>
        /// Кнопка +1
        /// </summary>
        public void Button_Plus1(object sender, RoutedEventArgs e)
        {
            var getNumber = Convert.ToInt32(lblNumber.Content);
            history.Push(getNumber.ToString());
            if (getNumber != randomNumber)
            {
                getNumber += 1;
                lblNumber.Content = getNumber.ToString();
                count++;
                lblCount.Content = count;
            }

            if (getNumber > randomNumber)
            {
                MessageBox.Show($"Упс... Вы перешагнули :(");
            }

            if (getNumber == randomNumber)
            {
                MessageBox.Show($"Ура! Вы завершили раунд. Вы сделали всего {count} шагов");
            }
        }

        /// <summary>
        /// Кнопка очистить все
        /// </summary>
        public void Button_Reset(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Button_Undo(object sender, RoutedEventArgs e)
        {
            lblNumber.Content = history.Pop();
        }

        /// <summary>
        /// Кнопка умножить на 2
        /// </summary>
        public void Button_X2(object sender, RoutedEventArgs e)
        {
            var getNumber = Convert.ToInt32(lblNumber.Content);
            history.Push(getNumber.ToString());
            if (getNumber != randomNumber)
            {
                getNumber *= 2;
                lblNumber.Content = getNumber.ToString();
                count++;
                lblCount.Content = count;
            }

            if (getNumber > randomNumber)
            {
                MessageBox.Show($"Упс... Вы перешагнули :(");
            }

            if (getNumber == randomNumber)
            {
                MessageBox.Show($"Ура! Вы завершили раунд. Вы сделали всего {count} шагов");
            }
        }

        /// <summary>
        /// Выйти из приложения
        /// </summary>
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
