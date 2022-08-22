// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int i = 1;
while (number > 0 )
{
    result += number % 2 * i;
    number = number / 2;
    i *= 10;
}

Console.WriteLine(result);