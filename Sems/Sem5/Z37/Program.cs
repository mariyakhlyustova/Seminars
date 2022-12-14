// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxvalue = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(num, minvalue, maxvalue);
PrintArray(arr);
Console.WriteLine();
PrintArray(MultiValue(arr));



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

int[] MultiValue(int[] array)
{
    int[] arr2 = new int[(array.Length + 1) / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arr2[i] = array[i] * array[(array.Length - 1) - i];
    }
    if (array.Length % 2 != 0)
    {
        arr2[arr2.Length - 1] = array[array.Length / 2];
    }
    return arr2;
}