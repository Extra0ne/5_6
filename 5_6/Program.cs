using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
          
    static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели \n" +
                          "1-Понедельник \n" +
                          "2-Вторник \n" +
                          "3-Среда \n" +
                          "4-Четверг \n" +
                          "5-Пятница \n" +
                          "6-Суббота \n" +
                          "7-Воскремеьне \n");
                                            
            int DayOfWeek;
            DayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (DayOfWeek)
            {
                case (int)WeekDays.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case (int)WeekDays.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case (int)WeekDays.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case (int)WeekDays.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case (int)WeekDays.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case (int)WeekDays.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case (int)WeekDays.Sunday:
                    Console.WriteLine("Воскресение");
                    break;
                default:
                    Console.WriteLine("Такого дня не существует");
                    break;
            }
            Console.ReadKey();
           
        }
    }
}
