// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[4];

FillArray(array);
PrintArray(array);

int maxFunc = Max(array);
int minFunc = Min(array);

Console.WriteLine($" -> {maxFunc - minFunc}");


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int Max(int[] array)
{
    int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    return min;
}