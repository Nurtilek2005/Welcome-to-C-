/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8

*/


string? strNum = null;
while (strNum == null)
{
    Console.Write("Введите трёхзначное число: ");
    strNum = Console.ReadLine();
    if (strNum == "")
    {
        Console.WriteLine("Вы не ввели число!");
        strNum = null;
        continue;
    }
    else if (strNum != null && strNum.Length != 3)
    {
        Console.WriteLine("Ваше число не трёхзначное!");
        strNum = null;
        continue;
    }
    Console.WriteLine(strNum[strNum.Length - 1]);
    break;
}