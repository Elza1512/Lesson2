// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int Sum(int num1)
  {
    int a = Convert.ToString(num1).Length;
    int b = 0;
    int result = 0;

    for (int i = 0; i < a; i++)
    {
      b = num1 - num1 % 10;
      result = result + (num1 - b);
      num1 = num1 / 10;
    }
   return result;
  }

int sum = Sum(num1);
Console.WriteLine("Сумма цифр в числе: " + sum);



