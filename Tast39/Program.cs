﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int [] CreateAttayRndInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++);
}
return array;
void PrintArray(int[] array) // Нужно дописать код с записи

void ReverseArray (int[] array) 
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size -1;
    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}

// int [] arr = CreateAttayRndInt(5, 1, 9);
// PrintArray(arr);
// ReverseArray(arr);
// PrintArray(arr);

// void ReverseArray1 (int[] array)
// {
//     int size = array.Length;

//     for (int i = 0; i < size / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[size - 1 - i];
//         array[size - 1 - i] = temp;
//     }
// }
