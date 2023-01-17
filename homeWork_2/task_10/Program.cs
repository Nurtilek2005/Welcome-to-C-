/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

string? strNum = null;
int number = 0, midNum = 0;

Console.Write("Введите трёхзначное число: ");
strNum = Console.ReadLine();

if (strNum != null && strNum != "")
{
    number = int.Parse(strNum);
    if (number < 1000 && number >= 100)
    {
        midNum = (number / 10) % 10;
        Console.WriteLine($"Второе число: {midNum}");
    }
    else
    {
        Console.WriteLine("Важе число не трёхзначное!");
    }
}
else
{
    Console.WriteLine("Введите корректное число!");
}
