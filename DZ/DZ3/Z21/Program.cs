// Задача 21  Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Ax=");
int Ax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ay=");
int Ay = int.Parse(Console.ReadLine()!);
Console.WriteLine("Az=");
int Az = int.Parse(Console.ReadLine()!);
Console.WriteLine("Bx=");
int Bx = int.Parse(Console.ReadLine()!);
Console.WriteLine("By=");
int By = int.Parse(Console.ReadLine()!);
Console.WriteLine("Bz=");
int Bz = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay),2) + Math.Pow((Bz - Az),2)));
