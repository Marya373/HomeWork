// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.Write("Введите число: ");
//int A = int.Parse(Console.ReadLine()!);

//Console.Write("Введите степень числа: ");
//int B = int.Parse(Console.ReadLine()!);

//int res = 1;

//for (int i = 1; i <= B; i++)
//{
//    res = A^B;
//}
//return res;

//Console.WriteLine({res});  
// Клим, не могу найти ошибку цикла. Решила другим способом

double A;
double B;
double C;

Console.WriteLine("Введите число, которое хотите возвести в степень: ");
A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень числа "+A+"");
B = Convert.ToDouble(Console.ReadLine());

C = Math.Pow(A, B);
Console.WriteLine("результат "+A+" в степени "+B+" равно "+C+"!");
Console.ReadLine();

