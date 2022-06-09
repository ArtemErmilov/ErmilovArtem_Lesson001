// Семинар 1. Задача 2:
// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите первое число ->");
string aString = Console.ReadLine();
int a = int.Parse(aString);

Console.Write("Введите второе число ->");
string bString = Console.ReadLine();
int b = int.Parse(bString);

Console.Write("Введите первое число ->");
string cString = Console.ReadLine();
int c = int.Parse(cString);

int max = a;

if (b > max) { max = b; }
if (c > max) { max = c; }

Console.WriteLine($"max={max}");
