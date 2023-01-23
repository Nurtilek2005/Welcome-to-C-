/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string promptText)
{
    Console.Write(promptText + ": ");
    string? strNum = Console.ReadLine();
    if (strNum == null || strNum.Trim() == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(strNum);
}

void CheckNumber(int number)
{
    if (!(number > 9999 && number < 100000))
    {
        Console.WriteLine("Ваше число не 5 значное!");
        return;
    }
    int firstNumber = number / 10000;
    int secondNumber = number % 10000 / 1000;
    int fourthNumber = number % 100 / 10;
    int fifthNumber = number % 10;
    if (firstNumber == fifthNumber && secondNumber == fourthNumber)
    {
        Console.WriteLine($"Да! Число: {number} является палиндромом.");
    } else {
        Console.WriteLine($"Нет! Число: {number} не является палиндромом.");
    }
}

int number = GetNumber("Введите пятизначную цифру");

CheckNumber(number);