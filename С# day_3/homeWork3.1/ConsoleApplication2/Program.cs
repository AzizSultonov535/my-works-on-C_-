using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isEven(a));
            Console.ReadKey();
        }
        static bool isEven(int numb)
        {
            return numb % 2 == 0;
        }
    }
}
