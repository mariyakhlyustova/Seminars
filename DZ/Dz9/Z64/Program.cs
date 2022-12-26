// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(FromN1(m, n));

string FromN1(int m, int n)
{
   
    if (m == n)
    {
        return m.ToString();
    }
    else
    {
        return  FromN1(m + 1, n) + ", " + m.ToString();
    }
}