﻿// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3  

internal class Program
{
    private static void Main(string[] args)
    {
        {
            int a;
            int b;

            Console.WriteLine("Введите число a");
            a = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите число b");
            b = int.Parse(Console.ReadLine()!);

            if (a > b)
            {
                Console.WriteLine("максимум " + a);
            }
            else
            {
                Console.WriteLine("максимум " + b);
            }
            Console.ReadLine();
        }
    }
}