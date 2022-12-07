// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine();
string n_1 = Console.ReadLine()!;
int n_1_n = int.Parse(n_1);
Console.WriteLine();
string n_2 = Console.ReadLine();
int n_2_n = int.Parse(n_2);
Console.WriteLine();
string n_3 = Console.ReadLine();
int n_3_n = int.Parse(n_3);
int max = n_1_n;
if (n_2_n > max) max = n_2_n;
if (n_3_n > max) max = n_3_n;
Console.WriteLine(max);