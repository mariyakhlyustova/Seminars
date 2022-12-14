// Задача 33: Задайте массив. Напишите программу,
//  которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите искомое значение");
int findvalue = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(num, minvalue, maxvalue);
PrintArray(arr);
bool answer = FindNumber(arr, findvalue);
if (answer) Console.WriteLine("да");
else Console.WriteLine("нет");


int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool FindNumber(int[] array,int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find) return true;
    }
    return false;
}