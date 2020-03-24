using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dear friend!");
            Console.WriteLine("Let's start SimpleCalc program!");
            Console.WriteLine("Select your operation (+, -, /, *)");
            string selection = Console.ReadLine();
            double a=0, b=0;
            switch (selection)
            {
                case "+":
                    Console.WriteLine("You selected + ");
                    Console.WriteLine("Please input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please input b: ");
                    b = double.Parse(Console.ReadLine());
                    double sum = a + b;
                    Console.WriteLine($"Result: {sum} ");
                    break;
                case "-":
                    Console.WriteLine("You selected - ");
                    Console.WriteLine("Please input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please input b: ");
                    b = double.Parse(Console.ReadLine());
                    double dif = a - b;
                    Console.WriteLine($"Result: {dif} ");
                    break;
               case "/":
                    Console.WriteLine("You selected + ");
                    Console.WriteLine("Please input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please input b: ");
                    b = double.Parse(Console.ReadLine());
                    double div = a/b;
                    Console.WriteLine($"Result: {div} ");
                    break;
                case "*":
                    Console.WriteLine("You selected + ");
                    Console.WriteLine("Please input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please input b: ");
                    b = double.Parse(Console.ReadLine());
                    double mult = a*b;
                    Console.WriteLine($"Result: {mult} ");
                    break;
                default:
                    Console.WriteLine("You pressed the wrong action");
                    break;
            }
            Console.WriteLine("Thx for using, see you next time!");
        }
    }
}
