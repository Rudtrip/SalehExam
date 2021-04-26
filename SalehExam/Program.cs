using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalehExam
{
    class Program
    {
        static void Main(string[] args)
        {

            int b; // b - число,на которое мы будем делить
            int result = 0; // сумма наших чисел
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 100; i++)
            {
                if (i % b == 0) // если остаток от деления i на b = 0, то суммируем
                    result += i;
            }

            Console.WriteLine($"Сумма натуральных чисел кратных {b} и < 100 = {result}");
            Console.ReadLine();

        }
    }
}
