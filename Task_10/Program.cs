﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число");
        var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));

        while (n >= 100)
        {
            n /= 10;
        }

        var r = n % 10;

        Console.WriteLine($"Вторая цифра: + {r}");
    }
}