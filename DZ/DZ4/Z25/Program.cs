// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("A= ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("B= ");
int numB = int.Parse(Console.ReadLine()!);


int expFunction = Power(numA, numB);
Console.WriteLine(expFunction);


int Power(int numberA, int numberB)
{
    int expAinB = numberA;
    for (int i = 1; i < numberB; i++)
    {
        expAinB = expAinB * numberA;
    }
    return expAinB;
}