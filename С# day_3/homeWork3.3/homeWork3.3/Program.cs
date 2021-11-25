using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a=");
            double c;
            double.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Введите b=");
            double d;
            double.TryParse(Console.ReadLine(), out d);
            Console.WriteLine(sumAB(c, d));
            Console.ReadKey(); 
        }

        static double sumAB(double a, double b)
        {
            Console.WriteLine("a+b=");
            return  a + b;
        }
    }
}
