using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Минимальное из трех чисел");
            Console.WriteLine("========================л");
            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());
            int Number3 = int.Parse(Console.ReadLine());
            int minNumber;
            if (Number1 < Number2 && Number1 < Number3)
            {
                minNumber = Number1;
            }
            else if(Number2 < Number3 && Number2 < Number1)
                {
                    minNumber = Number2;
                }
            else 
            {
                minNumber = Number3;
            }
            Console.WriteLine("Наименьшее из трех чисел " + minNumber);




        }
    }
}
