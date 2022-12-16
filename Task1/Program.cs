// Напишите программу, которая на вход принимает трехзначное число и на выходе  показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());

int res = (a /10) % 10;
Console.WriteLine(res);
