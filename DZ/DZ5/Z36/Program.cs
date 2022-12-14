﻿// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

FillArray(array);
PrintArray(array);

int sumFunc = SumOddPos(array);
Console.WriteLine($" -> {sumFunc}");


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumOddPos(int[] array)
{
    int sum = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            sum += array[i];
        }
    return sum;
}