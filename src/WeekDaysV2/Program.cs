using System;
using System.Collections.Generic;
namespace WeekDays_V2
{
    class Program
    {
        static Dictionary<DateTime, string> messegeKep = new Dictionary<DateTime, string>();
        static string mes;
        static DateTime day;
        static string DaySelection()
        {
            try
            {
                Console.WriteLine("So select a day in which you would like to leave a messege\nAttention! Use the next format: dd.mm.yyyy ");
                day = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"You selected {day}");
                //Selection();
                if (day != null)
                {
                    if (messegeKep.Count > 0)
                    {
                        foreach (KeyValuePair<DateTime, string> key in messegeKep)
                        {
                            DateTime a = key.Key;
                            if (a == day)
                            {
                                Console.WriteLine("This date is full, you can't leave messege here");
                                string t;
                                foreach (KeyValuePair<DateTime, string> val in messegeKep)
                                {
                                    DateTime b = val.Key;
                                    if (b == day)
                                    {
                                        t = val.Value;
                                        Console.WriteLine("Your messege is: {0}", t);
                                    }
                                }
                                Selection();
                            }
                            else Selection();

                        }
                    }
                    else
                    {
                        Console.WriteLine("You hade not have any messege yet");
                        Selection();
                    }
                }
                else
                {
                    Console.WriteLine("You have not entered day");
                }
               
            }

            catch (ArgumentException)
            {
                Console.WriteLine("This is arg ex");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Please write your date in a correct format");
            }
            catch (Exception ex)
            {
                Console.WriteLine("This is simple ex");
            }
            return Convert.ToString(day);
        }
        static void MessEnt()
        {
            Console.WriteLine("Are you sure that whant to leave a messege?");
            string answ = Console.ReadLine();
            if (answ == "Yes")
            {
                Console.WriteLine("Good!\nWrite your messege here: ");
                mes = Console.ReadLine();
                Console.WriteLine($"So your messege is: {mes}");
                messegeKep.Add(day, mes);
                Selection();

            }
            else
            {
                Console.Clear();
                Selection();
            }
        }
        

        static void Main(string[] args)
        {
            
           /* DateTime startDate = DateTime.Now;
            DateTime date = startDate.Date;
            DateTime[] week = new DateTime[7];
            week[0] = date;
            for (int i = 0; i < 7; i++)
            {
                week[i] = date.AddDays(i);
            }*/
            Console.WriteLine("Hello and welcome to the WeekDays v2.0, let's start\n");


            Selection();
            
            
            

        }
        static void Selection()
        {
            
            Console.WriteLine("Select your next action:\n1)Day selection\n2)Leave messege\n3)Leave app");
            try
            {
                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        DaySelection();
                        break;
                    case 2:
                        MessEnt();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("You selected wrong action, plese try again");
                        Selection();
                        break;


                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, input your selection by using number");
                Selection();
            }
        }
    }
}