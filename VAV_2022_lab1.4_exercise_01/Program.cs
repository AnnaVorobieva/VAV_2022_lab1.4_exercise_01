using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAV_2022_lab1._4_exercise_01
{
    internal class Program
    {
        /*Ввести целое число N > 0. Найти квадрат данного числа, 
          используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). 
          После добавления к сумме каждого слагаемого выводить текущее значение суммы 
          (в результате будут выведены квадраты всех целых чисел от 1 до N)*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int a = 1; (a > 0) && (a <= n); a++)
            {

                int s = 0;
                
                for (int i = 1; a <= n; a++)
                {
                    s += (2 * a) - 1;
                    
                    Console.WriteLine("Квадрат числа {0} равен {1}", a, s);
                }
                                

            }

            Console.ReadKey();

        }
    }
}
