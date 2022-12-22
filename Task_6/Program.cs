// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите число:");
if(number % 2 == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число нечетное");
    Console.Read();
}
