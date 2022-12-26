// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число n2 не кратно числу n1,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два числа");
int numput1 = int.Parse(Console.ReadLine()!);
int numput2 = int.Parse(Console.ReadLine()!);

if (numput1 % numput2 == 0) Console.WriteLine("кратно");
else Console.WriteLine ("не кратно, " + (numput1 % numput2));