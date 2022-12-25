// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// 67
Console.WriteLine("Введите a");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(MyPower(m, n));

//69
Console.WriteLine("Введите n");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumOfNumbers(n));

int SumOfNumbers(int n)
{
    if (n / 10 == 0)
    {
        return n;
    }
    else
    {
        return n % 10 + SumOfNumbers(n / 10);
    }
}

int MyPower(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * MyPower(a, b - 1);
    }
}
