// Задача 19. Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число:");
        string number = Console.ReadLine();
        int len = number.Length;

        if (len == 5);

        {
            if (number[0] == number[4] && number[1] == number[3])
            {
                Console.WriteLine("${number} - палиндром");
            }
            else
            {
                Console.WriteLine("${number} - не палиндром");
            }
        
        else
        {    
        Console.WriteLine($"Ошибка: {number} - не пятизначное");
        }
    }    
}}

