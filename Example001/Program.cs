// Семинар 1. Задача 1:
// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ->");
string aString = Console.ReadLine();
int a = int.Parse(aString);

Console.Write("Введите второе число ->");
string bString = Console.ReadLine();
int b = int.Parse(bString);

if (a != b)

{
    if (a > b)
    {
        Console.WriteLine($" max={a}, min={b}.");
    }
    else
    {
        Console.WriteLine($" max={b}, min={a}.");
    }
}

else
{
    Console.WriteLine("Первое и второе число равны друг другу.");
}