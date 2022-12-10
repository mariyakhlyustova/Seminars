// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("A= ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("B= ");
int numB = int.Parse(Console.ReadLine()!);

// 1 способ через функцию Math.Pow(), по рекомендации на семинаре.

Console.WriteLine(Math.Pow(numA, numB));


// 2 способ через цикл как указано в условии задачи.

// int expAinB = numA;
// for (int i = 1; i < numB; i++)
// {
//     expAinB = expAinB * numA;
// }
// Console.WriteLine(expAinB);