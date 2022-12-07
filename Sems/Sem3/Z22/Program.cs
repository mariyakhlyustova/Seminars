// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine();
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= num; i++) // чтобы не было зпт убираем (i = num)
{
    Console.Write(Math.Pow(i, 2) + ", ");
}

// Console.Write(Math.Pow(num, 2)); чтобы в конце не было зпт