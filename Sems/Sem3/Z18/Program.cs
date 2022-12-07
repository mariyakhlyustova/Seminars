// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
int quarter = int.Parse(Console.ReadLine()!);

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Четверть от 1 до 4");
}
else
{
    if (quarter == 1)
    {
        Console.WriteLine("x>0, y>0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine("x<0, y>0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("x<0, y<0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine("x>0, y<0");
    }
}

//int number;
//
// while (true) (пока ввод не будет корректным, цикл будет запрашивать ввод корректного введения)
// {
// Console.WriteLine("Номер четверти");
// number = int.Parse(Console.ReadLine()!);
// if (number < 1 || number > 4)
// {
// Console.WriteLine("Некорректный ввод. Повторите попытку");
// }
// else
// {
// break;
// }
// }

// if (number == 1)
// {
// Console.WriteLine("x > 0, y > 0");
// }
// else if (number == 2)
// {
// Console.WriteLine("x < 0, y > 0");
// }
// else if (number == 3)
// {
// Console.WriteLine("x < 0, y < 0");
// }
// else if (number == 4)
// {
// Console.WriteLine("x > 0, y < 0");
// }