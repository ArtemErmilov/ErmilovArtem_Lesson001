// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ->");
string aString = Console.ReadLine();
int a = int.Parse(aString);
int contr = 1;

while (contr<=a)
{
    if (contr%2 == 0)
    {
        Console.Write($"{contr}");
        if ((a%2==0 & contr==a)||(a%2==1 & contr==a-1))
        { 
            Console.WriteLine(". "); 
        }
        else
        {
           Console.Write(", "); 
        }
    }
    

contr++;
}


