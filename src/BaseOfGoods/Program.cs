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
       public static List<string> goods = new List<string>();
        /// <summary>
        /// Добавление товаров
        /// </summary>
        public static void GoodAdd()
        {
            Console.WriteLine("So now you should select which fruit you would like to add:\n1)Apple\n2)Banana\n3)Watermelon");
            int yourChoice = Convert.ToInt32(Console.ReadLine());
            switch (yourChoice)
            {
                case 1:
                    Apple apple1 = new Apple("Polskae", 45.2, true, true, 1);
                    Console.WriteLine($"You selected apple: {apple1}");
                    goods.Add(apple1.ToString());
                    StartMenu();
                       break;
                case 2:
                    Banana banana1 = new Banana("Asia", 55.2, true, false, 2);
                    Console.WriteLine($"You selected banana: {banana1}");
                    goods.Add(banana1.ToString());
                    StartMenu();
                    break;
                case 3:
                    Watermelon watermelon1 = new Watermelon("Grusia", 112.9, false, false, 3);
                    Console.WriteLine($"You selected watermelon: {watermelon1}");
                    goods.Add(watermelon1.ToString());
                    StartMenu();
                    break;
                default:
                    Console.WriteLine("You selected the wrong action, pls try again");
                    break;
            }

        }
        /// <summary>
        /// Просмотр всех товаров в базе
        /// </summary>
        public static void ShowGoods()
        {
            Console.WriteLine("Now you'v got:");
            for (int i = 0; i < goods.Count; i++)
            {

            
            
                //string name = Convert.ToString(i);///вывод в цифрах, надо стринговый
                Console.WriteLine(goods[i]);
            }
            StartMenu();
        }
        /// <summary>
        /// Удаление товаров
        /// </summary>
        public static void DeleteGoods()
        {
            Console.WriteLine("Select which fruit you would like to delete:\n1)Apple\n2)Banana\n3)Watermelon");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
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
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You have't got any fruits in base");
                StartMenu();
            }

            StartMenu();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Base of Goods, let's start\n");
            StartMenu();
        }


        static void StartMenu() 
        {
            Console.WriteLine("Please select your next action:\n1)Add new good in base\n2)Delete good from base\n3)Show full base of products\n4)Select to exit");           
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
