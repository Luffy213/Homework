using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа_обмена_значениями
{
    internal class Exercise
    {
        static void Main(string[] args)
        {
            int a=5, b=10;
            a = a + a;
            b = b - 5;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
