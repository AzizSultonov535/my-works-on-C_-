using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork4._3
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
            Console.ReadLine();
        }
        static void chekNum(double a, double b, double c)
        {
            if (a<b)
            {
                if(b<c)
                {
                    Console.WriteLine("Правильно a<b<c");
                }
                else
                {
                    Console.WriteLine("Правильно b>a>c");
                }
            }
            else
            {
                if (a>c)
                {
                    Console.WriteLine("Неправильно a>b>c");
                }
                else
                {
                    Console.WriteLine("Праавильно a<b<c");
                }
            }
        }
    }
}
