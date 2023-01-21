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

int checkNumber()
{
    
}

int nuber = GetNumber("Введите пятизначную цифру");

