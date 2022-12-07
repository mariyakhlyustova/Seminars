// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine();
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
if (number1 == Math.Pow(number2, 2) || number2 == Math.Pow(number1, 2)) Console.WriteLine("да");
else Console.WriteLine("нет");
