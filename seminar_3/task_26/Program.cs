/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetNumbersCount(int num)
{
    int count = 1;
    for (int i = num; i >= 10; i = i / 10)
    {
        count++;
    }
    return count;
}

int PromptNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = PromptNumber("Введите число чтобы узнать кол-во цифр: ");
Console.WriteLine(number + " -> " + GetNumbersCount(number));