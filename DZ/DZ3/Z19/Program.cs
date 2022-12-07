// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число ");
// string num=Console.ReadLine()!;

// if (num.Length == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine("да");
//     else Console.WriteLine("нет");
// }
// else Console.WriteLine("Введите пятизначное число ");

Console.WriteLine("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine()!);

if (num < 0)
{
    num = -num;
}

if (num < 10000 || num > 100000)
{
    Console.WriteLine("Введите пятизначное число ");
}
else
{
    int firstdigit = num / 10000;
    int seconddigit = (num / 1000) % 10;
    int fourthdigit = (num / 10) % 10;
    int fifthdigit = num % 10;

    if (firstdigit == fifthdigit && seconddigit == fourthdigit)
    {
        Console.WriteLine("да ");
    }
    else
    {
        Console.WriteLine("нет ");
    }
}

