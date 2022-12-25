// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(FromMToN(m, n));

string FromMToN(int m, int n)
{
   
    if (m == n)
    {
        return m.ToString();
    }
    else
    {
        return m.ToString() + ", " + FromMToN(m + 1, n);
    }
}
