// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine();
string n_1 = Console.ReadLine()!;
int n_1_n = int.Parse(n_1);
Console.WriteLine();
string n_2 = Console.ReadLine();
int n_2_n = int.Parse(n_2);
int max = n_1_n;
if (n_2_n > max) max = n_2_n;
Console.WriteLine("max = " + max);