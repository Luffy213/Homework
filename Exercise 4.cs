using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   string login;
            string password;
            int tries=0;
            
            do
            {

                Console.WriteLine("=============");
                Console.WriteLine("Введите логин");
                login = Console.ReadLine();
                Console.WriteLine("==============");
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                 if (login=="root" && password=="GeekBrains")
                   
                {
                    Console.WriteLine("================");
                    Console.WriteLine("Добро пожаловать");
                    tries = 4;
                    Console.ReadKey();     
                }
                else 
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Вы ввели неверный логин или пароль.Повторите попытку ввода");
                    Console.ReadKey();
                    ++tries;
                 }
                           } while (tries < 3) ;
            
           
            





        }
    }
}
