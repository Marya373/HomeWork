// Напишите программу, которая принимает на вход число (N) и выдает 
// таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11

namespace Prime
{
    class Program
    {
    public static bool IsPrime(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0)
            return false;
        }
            return true;
    }
    static void Main (string[] args)           
    {
        Console.WriteLine("Введите значение диапазона 1.....N");
        Console.WriteLine("N =");
        if ((!int.TryParse(Console.ReadLine(), out int result)) || (result < 0))
            Console.WriteLine("Число должно быть положительным и целым");
        Console.WriteLine($"Простые числа из диапазона от 1 до {result}");
        int count = 0;
        for (int i = 1; i <= result; i++)
        {
        if (IsPrime(i))
        {
            Console.Write($"(i)");
            count++;
        } 
    }
    Console.WriteLine("");
    Console.WriteLine($"Найдено {count} простых чисел из диапазона от 1 до {result}");
    } 
    }
} 

 

