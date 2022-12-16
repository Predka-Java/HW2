// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру: ");
int a = int.Parse(Console.ReadLine());
while(a > 7){       // редактирование числа с любого количества недель до одной =)
a = a - 7;
}
if(a < 6) {
    Console.WriteLine("No");
} else  {
    Console.WriteLine("Yes");
}