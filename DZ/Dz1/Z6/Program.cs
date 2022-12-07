// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine();
string n = Console.ReadLine();
int n_n = int.Parse(n);
if (n_n % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

/* Console.WriteLine("Введите 3 числа");
 
int number1 = int.Parse(Console.ReadLine()!);
 
 
// int counter = 2;
// while (counter <= number1)
// {
//     Console.Write($"{counter} ");
//     counter += 2; // Тоже самое, что counter = counter + 2;
// }
 
for (int i = 2; i <= number1; i+=2)
{
    Console.Write($"{i} ");
} */