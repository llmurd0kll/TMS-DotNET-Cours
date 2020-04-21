using System;
using System.Linq;
using System.Collections.Generic;
/*Что нужно для реализации:
 * Добавление нового товара в базу
 * Удаление товара из базы
 * Поиск товара 
 * 
 * 
 * 
 */


namespace BaseOfGoods
{
   

    partial class Program
    {
       public static List<int> goods = new List<int>();

        public static void GoodAdd()
        {
            Console.WriteLine("So now you should select which fruit you would like to add:\n1)Apple\n2)Banana\n3)Watermelon");
            int yourChoice =Convert.ToInt32(Console.ReadLine());
            switch (yourChoice)
            {
                case 1:
                    Console.WriteLine("You selected apple");
                    goods.Add(1);
                    StartMenu();
                       break;
                case 2:
                    Console.WriteLine("You selected banana");
                    goods.Add(2);
                    StartMenu();
                    break;
                case 3:
                    Console.WriteLine("You selected watermelon");
                    goods.Add(3);
                    StartMenu();
                    break;
                default:
                    Console.WriteLine("You selected the wrong action, pls try again");
                    break;
            }

        }

        public static void ShowGoods()
        {
            Console.WriteLine("Now you'v got:");
            foreach (int i in goods)
            {
                string name = Convert.ToString(i);///вывод в цифрах, надо стринговый
                Console.WriteLine(name);
            }
            StartMenu();
        }
        
        public static void DeleteGoods()
        {
            Console.WriteLine("Select which fruit you would like to delete:\n1)Apple\n2)Banana\n3)Watermelon");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("You selected Apple");
                    goods.RemoveAt(1);
                    break;
                case 2:
                    Console.WriteLine("You selected Banana");
                    goods.RemoveAt(2);
                    break;
                case 3:
                    Console.WriteLine("You selected Banana");
                    goods.RemoveAt(3);
                    break;
                default:
                    Console.WriteLine("You selected wrong action, pls try again");
                    break;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Base of Goods, let's start\n");
            StartMenu();
        }


        static void StartMenu() 
        {
            Console.WriteLine("Hello, please select your next action:\n1)Add new good in base\n2)Delete good from base\n3)Show full base of products\n4)Select to exit");           
            try
            {
                int answ = Convert.ToInt32(Console.ReadLine());
                switch (answ)
                {
                    case 1:
                        GoodAdd();
                        break;
                    case 2:
                        DeleteGoods();
                        break;
                    case 3:
                        ShowGoods();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("You selected wrong action, plese try again");
                        StartMenu();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, input your selection by using number");
                StartMenu();
            }


        }



    }
}
