using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anketa
{
    internal class anketa
    {
        static void Main(string[] args)
        {
            string a = "Роман", b = "Скалабан", c = "Владимирович";
            Console.WriteLine("Ваше имя? Ваша фамилия ? Ваше отчество ?"); 
            Console.WriteLine($"{a} {b} {c}");
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine("{0} {1} {2}", a, b, c);




        }
    }
}
