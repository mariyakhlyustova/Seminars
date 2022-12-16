Console.WriteLine("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxvalue = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(num, minvalue, maxvalue);
PrintArray(arr);
Console.WriteLine($" -> {ReverseArray(arr)}");



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

int[] ReverseArray(int[] array)
{
        for (int i = 0; i < array.Length/2; i++)
        {
            int buff = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = array[i];
        }
    return array;
}
