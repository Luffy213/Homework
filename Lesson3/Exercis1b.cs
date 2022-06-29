using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    internal class Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex complex)
        {
            Complex res = new Complex();
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
            Complex res1=new Complex();
            res1.re = re - complex.re;
            res1.im = im - complex.im;
            return res1;
        }
        public Complex Multi(Complex complex)
        {
            Complex res2 = new Complex();
            res2.re = re * complex.re;
            res2.im = im * complex.im;
            return res2;
        }
       





    }

    internal class Sample01
    {
        static void Main(string[] args)
        {
            //Object
            
            



            Complex complex01 = new Complex();
            complex01.re = 2;
            complex01.im = 3;


            Complex complex02 = new Complex();
            complex02.re = -1;
            complex02.im = -2;


            Complex complex03 = complex01.Plus(complex02);
            Complex complex04 = complex01.Minus(complex02);
            Complex complex05 = complex01.Multi(complex02);

            Console.WriteLine($"{complex01}  +   {complex02}  = {complex03}");
            Console.WriteLine($"{complex01}  -   {complex02}  = {complex04}");
            Console.WriteLine($"{complex01}  *   {complex02}  = {complex05}");
            Console.ReadKey();
        }
        }
    }
