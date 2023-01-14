/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

string? strNum = null;
int number = 0;

Console.WriteLine("Введите число, что бы узнать, является ли число чётным: ");
strNum = Console.ReadLine();

if (strNum != null && strNum != "")
{
    number = int.Parse(strNum);
    Console.Write("Ваше число: ");
    Console.Write(number);
    if ((number % 2) == 0)
    {
        Console.WriteLine("является чётным");
    }
    else
    {
        Console.WriteLine("не чётный");
    }
}
else
{
    Console.WriteLine("Вы ничего не ввели!");
}