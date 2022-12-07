// определить координатную плоскость, в которой находится точка (x, y).

Console.WriteLine("Введите X");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y");
int y = int.Parse(Console.ReadLine()!);
 
if (x == 0 || y == 0)
{
    Console.WriteLine("Числа не должны быть равны 0");
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Номер четверти: 1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Номер четверти: 2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Номер четверти: 3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Номер четверти: 4");
    }
}
