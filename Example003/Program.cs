//  Семинар 1. Задача 3:
// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число ->");
string aString = Console.ReadLine();
int a = int.Parse(aString);

if (a%2 == 1)
{
    Console.WriteLine($"Число {a} не чётное.");
}
else
{
    Console.WriteLine($"Число {a} чётное.");
}