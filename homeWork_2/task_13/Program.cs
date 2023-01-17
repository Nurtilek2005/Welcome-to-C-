/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

string? strNum = null;
int number = 0, thirdNum = 0;

Console.Write("Введите число, для того что бы получить третью цифру: ");
strNum = Console.ReadLine();

if (strNum != null && strNum != "")
{
    number = int.Parse(strNum);
    if (number >= 100)
    {
        while (number / 10 > 100) {
            number /= 10;
        }
        thirdNum = number % 10;
        Console.WriteLine($"Третья цифра заданного числа: {thirdNum}");
    }
    else
    {
        Console.WriteLine("В вашем числе нету третьей цифры!");
    }
}
else
{
    Console.WriteLine("Введите корректное число!");
}
