using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш возвраст?");
            int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(personAge(a));
            //if (personAge(a) == true)
            //    Console.WriteLine("Имеете право");
            //if (personAge(a) == false)
            //    Console.WriteLine("Не имеете право");
            Console.WriteLine(personAge(b));
            Console.ReadKey();
        }
        static string personAge(int age)
        {
            string a = "";
            if (age >= 18 == true)
                a = ("Имеете право");
            if (age >= 18 == false)
                a = ("не имеете право");
            return a;
            //return age >= 18 == true;
        }
    }
}
