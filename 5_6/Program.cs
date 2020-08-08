using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6
{
    class Program
    {
        public enum DayOfWeek
        {
            Понедельник = 0,
            Вторник = 1,
            Среда = 2,
            Четверг = 3,
            Пятниццо = 4,
            Суббота = 5,
            Воскресенье = 6
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
            DayOfWeek = int.Parse(Console.ReadLine());
            switch (DayOfWeek)
            {
                case 0:
                    Console.WriteLine("Понедельник");
                    break;
                case 1:
                    Console.WriteLine("Вторник");
                    break;
                case 2:
                    Console.WriteLine("Среда");
                    break;
                case 3:
                    Console.WriteLine("Четверг");
                    break;
                case 4:
                    Console.WriteLine("Пятница");
                    break;
                case 5:
                    Console.WriteLine("Суббота");
                    break;
                case 6:
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
