using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkDay6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Max value: " + int.MaxValue.ToString());
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                proizvedenie(a, b);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void proizvedenie(int a, int b)
        {
            if (a*b> int.MaxValue)
            {
                throw new OverflowException();
            }
            else
            {
                Console.WriteLine((a * b).ToString());
            }
        }
    }
}
