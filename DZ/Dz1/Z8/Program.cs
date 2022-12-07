// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine();
string n = Console.ReadLine()!;
int n_n = int.Parse(n);
int i = 1;
while (i <= n_n)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
    i++;
}