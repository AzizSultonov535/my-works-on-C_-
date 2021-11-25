using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            chekNum(a, b, c);
            Console.ReadKey();
        }

        static void chekNum(double a=0, double b = 0, double c= 0)
        {
            if (a > 0 )
            {
                a = Math.Pow(a, 2);
                Console.WriteLine("число a^2=" + a);
            }
            else
            {
                //Console.WriteLine("число а отрицательное");
                Console.WriteLine("число a=" + a);
            }
            if (b > 0)
            {
                b = Math.Pow(b, 2);
                Console.WriteLine("число b^2=" + b);
            }
            else
            {
                //Console.WriteLine("число b отрицательное");
                Console.WriteLine("число b=" + b);
            }
            if (c > 0)
            {
                c = Math.Pow(c, 2);
                Console.WriteLine("число c^2=" + c);
            }
            else
            {
                //Console.WriteLine("число c отрицательное");
                Console.WriteLine("число c=" + c);
            }
        }
    }
}
