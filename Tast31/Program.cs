// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [ -9. 9].
// Найдите сумму отрицательных и положительных элементов массива. Вывод результата.


int [] CreateArrayRndInt(int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}