using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    /*
     * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
     * «Хорошим» называется число, которое делится на сумму своих цифр. 
     * Реализовать подсчёт времени выполнения программы, используя структуру DateTime
     */
    class Program
    {
        static bool IsSimple (int n) 
        { for (int i = 2; i <= n / 2; i++) 
                if (n % i == 0)
                {
                    return false;
                }   
            return true; 
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now; 
            int k = 0; 
            for (int i = 2; i < 100000000; i++) 
                if (IsSimple(i)) 
                {
                    k++; 
                    Console.WriteLine("{0} {1}", k, i); 
                }
            Console.WriteLine(k); 
            Console.WriteLine(DateTime.Now - start);
        }
    }
}
