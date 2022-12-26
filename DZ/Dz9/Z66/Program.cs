﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

if (m < n) Console.WriteLine(SumElementsMinM(m, n));
else Console.WriteLine(SumElementsMaxM(n, m));

int SumElementsMinM(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        return n  + SumElementsMinM(m, n - 1);
    }
}

int SumElementsMaxM(int n, int m)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m  + SumElementsMaxM(n, m - 1);
    }
}