using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            double h, i;           
            Console.WriteLine(" Введите массу человека");

            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Масса =" + m +"kg");
            Console.WriteLine("Введите рост");
            h = double.Parse (Console.ReadLine());
            Console.WriteLine("Рост=" + h +"m");          
            i = m / (h * h);
            string result = string.Format("{0:f2}", i);        
            Console.WriteLine("Индекс массы тела=" + result);







        }
    }
}
