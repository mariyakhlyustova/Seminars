Console.WriteLine();
string num = Console.ReadLine()!;
if (num.Length < 0 )
{
    if (num.Length < 3) Console.WriteLine("третьей цифры нет");
    else Console.WriteLine(num[2]);
}
Console.WriteLine(num[3]);
// делим в цикле любое число до нужного разряда на 10 и выводим остаток деления на 10 