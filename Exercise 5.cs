using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу тела");
            int m =int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            double h =double.Parse(Console.ReadLine());
            double I = m / (h * h);
            Console.WriteLine("Индекс массы тела=" + I);
            if (I>18.5&&I<25)
            {
                Console.WriteLine("У вас нормальный индекс массы тела");
            }
            else if(I>25&&I<30)
            {
                Console.WriteLine("Ты жирный. Иди в зал");
            }           
            else if (I<18.5)
            {
                Console.WriteLine("Ты слишком худой. Сходи поешь");
            }

        }
    }
}
