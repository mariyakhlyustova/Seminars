// Задача 28: Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
 
Console.WriteLine(multiFunction(num));
 

int multiFunction(int number)
{
    int multi = 1;
    for (int i = 1; i <= number; i++)
    {
        multi *= i; // multi=multi*i
    }
    return multi;
}