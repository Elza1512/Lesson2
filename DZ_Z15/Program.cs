// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число: ");

int a = Convert.ToInt32(System.Console.ReadLine());

if( a == 1) System.Console.WriteLine("Не является выходным днем");
else if( a == 2) System.Console.WriteLine("НеНе является выходным днем");
else if( a == 3) System.Console.WriteLine("Не является выходным днем");
else if( a == 4) System.Console.WriteLine("Не является выходным днем");
else if( a == 5) System.Console.WriteLine("Не является выходным днем");
else if( a == 6) System.Console.WriteLine("Является выходным днем");
else if( a == 7) System.Console.WriteLine("Является выходным днем");
else System.Console.WriteLine("Число не в диапозоне 1-7");