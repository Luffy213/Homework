using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace расстояние_между_координатами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, r;
            Console.WriteLine("Введите координату x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x=" + x1);
            Console.WriteLine("Введите координату x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("x=" + x2);
            Console.WriteLine("Введите координату y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x=" + y1);
            Console.WriteLine("Введите координату y2");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("x=" + y2);
            
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            string result = string.Format("{0:f2}", r);
            Console.WriteLine("r="+result);

        }
    }
}
