// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

internal class Program
{
    private static int Main(string[] args)
    {
        {
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            int c = int.Parse(Console.ReadLine()!);
            int max;

            Console.WriteLine("Введите число а");
            Console.WriteLine("Введите число b");
            Console.WriteLine("Введите число c");

            {
                max = a > b ? a > c ? a : c : b > c ? b : c;
                return max;
            }
            Console.WriteLine("Максимум трех чисел" + max);
        

        }
        Console.ReadLine();
    }
}