/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт
, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Clear();
Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);

int result = (number1 % 2);

if (result == 0)
{
   Console.WriteLine("Четное");
}
if (result != 0)
{
Console.WriteLine("Нечетное");
}