﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("A= ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("B= ");
int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine(Math.Pow(A, B));

int AB = A;
for (int i = 1; i < B; i++)
{
    AB = AB * A;
}

Console.WriteLine(AB);
