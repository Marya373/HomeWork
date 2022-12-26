// Задача 23. Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число:");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i*i*i}, ");
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}