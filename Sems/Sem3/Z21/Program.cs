// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Ax=");
int Ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ay=");
int Ay = int.Parse(Console.ReadLine()!);

Console.WriteLine("Bx=");
int Bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("By=");
int By = int.Parse(Console.ReadLine()!);


Console.WriteLine(Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay),2)));