// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести?");
int num = int.Parse(Console.ReadLine()!);
int[] arr = new int[num];
for (int j = 0; j < num; j++)
{
    Console.WriteLine($"Введите {j + 1} число");
    arr[j] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine($" -> {countFunc(arr)}");

int countFunc(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0) count++;
    }
    return count;
}