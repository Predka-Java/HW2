// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if(n < 100) {
    Console.WriteLine("Третьей цифры нет");
    
} else {
    while (n > 1000) {
      n = n / 10;
    }
   n = n % 10;
} 
Console.WriteLine(n);