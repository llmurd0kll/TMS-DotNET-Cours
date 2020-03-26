using System;
using System.Collections.Generic;
namespace Weekdays
{
    class Program
    {
        enum Weekdays {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        static Weekdays[] weekdays = new Weekdays[7] { Weekdays.Monday, Weekdays.Tuesday, Weekdays.Wednesday, Weekdays.Thursday, Weekdays.Friday, Weekdays.Saturday, Weekdays.Sunday };
        static Dictionary<int, string> messegeKep = new Dictionary<int, string>();
        static int num;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, dear friend!\n");
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, weekdays[i]);
            }
            MainMenu1();

            
        }

        static int dayEnter()
        {

            Console.WriteLine("Please, enter the day:");
            num = int.Parse(Console.ReadLine());
            if (num > 0 && num < 8)
            {
                Console.WriteLine("Your day: {0}", weekdays[num - 1]);
                foreach (KeyValuePair<int, string> key in messegeKep)
                {
                    int a = key.Key;
                    if (a == num)
                    {
                        Console.WriteLine("This date is full, you can't leave messege here");
                        MainMenu1();
                    }


                }
            }
            else MainMenu1();



            return num;
        }
        static void messegeLeft(int i)
        {
            string mes, ansv;
            Console.WriteLine($"Would you like write something for this day?");
            ansv = Console.ReadLine();
            if (ansv == "Yes")
            {

                Console.WriteLine("Plese, leave your messege here: ");
                mes = Console.ReadLine();
                messegeKep.Add(num, mes);
                Console.WriteLine("So now you've got this messege: {0}", mes);
                MainMenu();

            }
            else if (ansv == "No")
            {
                Console.WriteLine("Tnx for using, see you next time");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Oh NO!\n Plese write your answer correctly next time!");

            }
        }
        static void MainMenu()
        {

            Console.WriteLine("Would you like to select another day?");
            string ansv2 = Console.ReadLine();
            if (ansv2 == "Yes")
            {
                Console.WriteLine("Ok");
                MainMenu1();

            }
            else Console.WriteLine("By");



            //////////Вот здесь надо условие мол если метод выше успешно, то дальше след метод, если не успешно, то должно прекращаться

        }
        static void MainMenu1()
        {
            dayEnter();
            messegeLeft(num);
        }


    }
}
