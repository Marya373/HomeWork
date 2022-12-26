// Задача 19. Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine()!;

if (input.Length == 5)
{
    if (input[0] == input[4] && input[1] == input[3])
    {
        Console.WriteLine("Введенное число - палиндром");
    }
    else
    {
        Console.WriteLine("Введенное число - не палиндром");
    }
}
else
{
    Console.WriteLine("Введенное число не пятизначное");
}