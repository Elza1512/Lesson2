﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 - 1101

int number = 13;

void DecToBin(int num)
{
    if (num == 0) return;
    DecToBin(num / 2);
    Console.Write(num % 2);
}
 
DecToBin(number);