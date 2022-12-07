// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine();
int numput = int.Parse(Console.ReadLine()!);

if (numput <= 5) Console.WriteLine("нет");
if (numput == 6 || numput == 7) Console.WriteLine("да");