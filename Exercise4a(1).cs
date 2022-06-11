using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_переменных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10,c = 15;
            b =c-b ;
            a = c-a;

           
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
