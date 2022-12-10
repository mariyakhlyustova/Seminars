// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int countFunction = Calculatecount(num);
Console.WriteLine(countFunction);

// Func
int Calculatecount(int number)
{
    int count = 1;
    while (number >= 10)
    {
        number = number / 10;
        count++;
    }
    return count;
}