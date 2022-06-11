using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 0;

            do
            {
                a = int.Parse(Console.ReadLine());
                if (a > 0 && a % 2 == 1)
                    sum += a;

            } while (a != 0);

            Console.WriteLine("Сумма нечетных чисел равна " + sum);



        }
    }
}
