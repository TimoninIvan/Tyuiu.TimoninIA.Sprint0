﻿using Tyuiu.TimoninIA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.TimoninIA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            //Пример развлетвляющейся структуры находится в библиотеке классов в методе Division
            Console.WriteLine("A / B = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}