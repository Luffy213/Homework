using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Exercise1
    {

      
        static void Main(string[] args)
        {
            do
            {
               
                string login = Console.ReadLine();
                bool login1;
                if (login.Length >= 2 && login.Length <= 10)
                {
                    Console.WriteLine("Данный логин - {0}, вполне корректен", login);
                    login1 = true;
                    break;
                }
                else
                { 
                    Console.WriteLine("Логин не корректен");
                    login1 = false; 
                }
            } while (true);
            


        }
    }
}
