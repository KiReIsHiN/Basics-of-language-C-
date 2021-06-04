using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.ComplStruct
{
    class ComplStruct
    {
        //Создаем тип данных структура
        public struct Complex
        {
            //Создаем поле, которое хранит действительную часть комплексного числа
            public double re;
            //Создаем поле, которое хранит мнимую часть комплексного числа
            public double im;

            //Создаем конструктор комплексных чисел
            public Complex(double re, double im)
            {
                this.re = re; // помещаем значение из дабл ре в скобках в дабл ре
                this.im = im; // помещаем значение из дабл им в скобках в дабл им
            }

            //Создаем метод вывода в консоль
            public void Print()
            {
                Console.WriteLine($" {re} + {im}i");
            }
        }
    }
}
