﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine();
int numput = int.Parse(Console.ReadLine()!);
Console.WriteLine((numput % 100 - (numput % 100) % 10) / 10); // просто numput % 10