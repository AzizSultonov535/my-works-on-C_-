using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите называния месяца с нижнем регистором");
            string month=Console.ReadLine();
            searchMonth(month);

            Console.ReadKey();
        }
        static void searchMonth(string month)
        {
            int a = 0;
            switch (month)
            {
                case "январь":
                    a = 30;
                    break;
                case "февраль":
                    a = 28;
                    break;
                case "март":
                    a = 30;
                    break;
                case "апрель":
                    a = 31;
                    break;
                case "май":
                    a = 30;
                    break;
                case "июнь":
                    a = 31;
                    break;
                case "июль":
                    a = 30;
                    break;
                case "август":
                    a = 31;
                    break;
                case "сентябрь":
                    a = 30;
                    break;
                case "октябрь":
                    a = 31;
                    break;
                case "ноябрь":
                    a = 30;
                    break;
                case "декабрь":
                    a = 31;
                    break;
                default:
                    //Console.WriteLine("Такого месяца не существует! Или называние месяца написано с верхним регистором");
                    Console.WriteLine("Месяц, в котором вы вводили ");
                    break;
            }
            Console.WriteLine("состоит из "+a+" дней");
        }
    }
}
