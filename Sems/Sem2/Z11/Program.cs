// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);

Console.WriteLine(number);

int firstDigit = number / 100;
int secondDigit = number % 10;
 
Console.Write(firstDigit);
Console.Write(secondDigit);