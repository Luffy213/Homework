using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1b
{
    internal class Exercise2
    {
        class exercise2
        {

            static int NeedInt()
            {
                while (true)
                    if (!int.TryParse(Console.ReadLine(), out int x))
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                    else return x;
            }

            static int CheckExeption()
            {
                int result=0;
                bool exception;
                do
                {
                    exception = false;                              
                    try
                    {
                        result = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        exception = true;
                        string message = ex.Message;
                        Console.WriteLine("Возникло исключение: " + message);
                        Console.Write("Пожалуйста, повторите ввод: ");
                    }

                } while (exception);
                return result;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
                Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

                int AmountOfNumbers = 0;
                while (true)
                {
                    int number = CheckExeption();
                    if (number == 0)
                    {
                        break;
                    }
                    else if (number > 0 && number % 2 == 1)
                    {
                        AmountOfNumbers++;
                    }
                }

                Console.WriteLine( "Количество чисел: " + AmountOfNumbers);

                Console.ReadKey();

            }
        }
    }
}
