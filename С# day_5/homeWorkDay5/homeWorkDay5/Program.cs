using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            //________TAFTISHI MASALAI 1

            sumNuminrange100_500();

            //________TAFTISHI MASALAI 2

            //Console.WriteLine("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //sumInRange_a_500(a);

            //________TAFTISHI MASALAI 3

            //Console.WriteLine("b=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //sumNums1(b);

            //________TAFTISHI MASALAI 4

            //Console.WriteLine("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("b=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //sumNumsInRange_a_b(a, b);
            
            Console.ReadKey();
        }

        static void sumNuminrange100_500()
        {
            int a = 100;
            int b = 0;
            while (a < 500)
                {
                    b=b+a;
                    a++;
                }
            Console.WriteLine("Сумма целых чисел от 100 до 500 = " + b);
        }

        static void sumInRange_a_500(int a)
        {
            int ot = a;
            int c = 0;
            if (a<500)
            {
                while (a < 500)
                {
                    c = c + a;
                    a++;
                }
                Console.WriteLine("Сумма целых чисел от " + ot + " до 500 = " + c);
            }
            else
            {
                Console.WriteLine("Error!!!  a>b");
            }
        }

        static void sumNums1(int b)
        {
            int a = b;
            int result = 0;
            for (int i = -10; i < a+1; i = i + 1)
                result = result + i;
                
            Console.WriteLine("Сумма целых чисел от -10 до " +b+" = " + result);
        }

        static void sumNumsInRange_a_b(int a,int b)
        {
            int result = 0;
            if (a<b)
            {
                for (int i = a; i < b + 1; i = i + 1)
                    result = result + i;
                Console.WriteLine("Сумма целых чисел от " + a + " до " + b + " = " + result);
            }
            else
            {
                Console.WriteLine("Error!!! a>b");
            }
        }
    }
}
