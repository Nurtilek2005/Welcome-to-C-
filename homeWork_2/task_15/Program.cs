/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string? strNum = null;
int dayOfWeek = 0;

Console.Write("Введите день недели в ввиде цифры, для того что бы узнать выходной ли: ");
strNum = Console.ReadLine();

if (strNum != null && strNum != "")
{
    dayOfWeek = int.Parse(strNum);
    string dayOfWeekName = GetDayOfTheWeek(dayOfWeek);
    if (dayOfWeek == 6 || dayOfWeek == 7)
    {
        Console.WriteLine($"Да, cегодня выходной! {dayOfWeekName}!");
    }
    else if (dayOfWeek >= 1 && dayOfWeek <= 5)
    {
        Console.WriteLine($"Нет, cегодня рабочий день. {dayOfWeekName}.");
    }
    else
    {
        Console.WriteLine($"Нет, ошибка! Сегодня день {dayOfWeekName}.");
    }
}
else
{
    Console.WriteLine("Введите корректное число!");
}

// Надеюсь что функции разрешены в домашке...
// Если что, извините. Просто не знал.

string GetDayOfTheWeek(int dayOfTheWeek)
{
    if (dayOfTheWeek == 1) return "Понедельник";
    else if (dayOfTheWeek == 2) return "Вторник";
    else if (dayOfTheWeek == 3) return "Среда";
    else if (dayOfTheWeek == 4) return "Четверг";
    else if (dayOfTheWeek == 5) return "Пятница";
    else if (dayOfTheWeek == 6) return "Суббота";
    else if (dayOfTheWeek == 7) return "Воскресенье";
    else return "404";
}
