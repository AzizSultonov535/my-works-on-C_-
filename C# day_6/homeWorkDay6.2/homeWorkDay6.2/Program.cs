using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkDay6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(-10,10);
            try
            {
                Console.WriteLine(number);
                Console.WriteLine(myMethod(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        static int myMethod(int a)
        {
            if (a > 0 && a % 2 == 0)
            {
                Console.WriteLine(Math.Pow(a, 2));
            }
            else if (a < 0)
            {
                throw new Exception("Error!!!");
            }
            return a;
        }
    }
}
