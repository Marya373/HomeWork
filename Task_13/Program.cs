// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


            Console.Write("Введите любое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int lastThreeDigits = num % 100;

            if (lastThreeDigits <= 0)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else
            {
                if (lastThreeDigits > 3)
                {
                    num = num % 10;
                    num = num / Convert.ToInt32(Math.Pow(10, lastThreeDigits - 3)); 
                }
                
                Console.WriteLine($"Третья цифра введённого числа: {num}");
            }
            