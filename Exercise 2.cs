using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a=int.Parse(Console.ReadLine());
            if (a>0&&a<100)
            {
                Console.WriteLine("Вы ввели двузначное число");
            }
            else if(a>100&&a<1000)
            {
                Console.WriteLine("Вы ввели трехзначное число");
            }
            else if (a > 1000 && a < 10000)
            {
                Console.WriteLine("Вы ввели четырехзначное число");
            }
            else if (a > 10000 && a < 100000)
            {
                Console.WriteLine("Вы ввели пятизначное число");
            }
            else if (a > 100000 && a < 1000000)
            {
                Console.WriteLine("Вы ввели шестизначное число");
            }
        }
    }
}
