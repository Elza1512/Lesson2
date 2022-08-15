﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}   
else 
{
    if (num >= 1000) num /= 10;
    int result = num % 10;
    {
        Console.WriteLine($"Третья цифра введенного числа {result}");
    }
}
