// Задача 29: Напишите программу, которая принимает число N и  задаёт массив
// из N элементов и выводит их на экран.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int[] array = new int[num];

FillArray(array);
PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, num);
    }
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}