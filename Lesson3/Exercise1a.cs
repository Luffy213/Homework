using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    internal struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex complex)
        {
            Complex res;
            res.re = re + complex.re;
            res.im = im + complex.im;
            return res;
        }
        public override string ToString()
        {
            return $"{re} + {im}i";

        }
        public Complex Minus(Complex complex)
        {
            Complex res1;
            res1.re = re - complex.re;
            res1.im = im - complex.im;
            return res1;
        }




    }

    internal class Sample01
    {
        static void Main(string[] args)
        {
            //Object

          
           

            Complex complex01;
            complex01.re = 2;
            complex01.im = 3;


            Complex complex02;
            complex02.re = -1;
            complex02.im = -2;

            Complex complex03 = complex01.Plus(complex02);
            Complex complex04 = complex01.Minus(complex02);

            Console.WriteLine($"{complex01}  +   {complex02}  = {complex03}");
            Console.WriteLine($"{complex01}  -   {complex02}  = {complex04}");
            Console.ReadKey();
        }
    }
}