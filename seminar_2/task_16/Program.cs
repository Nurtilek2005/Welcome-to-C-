/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/


string? firstNumStr = null;
string? secondNumStr = null;

Console.Write("Введите первое число: ");
firstNumStr = Console.ReadLine();
if (firstNumStr != null && firstNumStr != "")
{
    int firstNum = int.Parse(firstNumStr);
    Console.Write("Введите второе число: ");
    secondNumStr = Console.ReadLine();
    if (secondNumStr != null && secondNumStr != "")
    {
        int secondNum = int.Parse(secondNumStr);
        if (firstNum > secondNum)
        {
            int tempNum = firstNum;
            firstNum = secondNum;
            secondNum = tempNum;
        }
        if ((firstNum * firstNum) == secondNum)
        {
            Console.WriteLine($"Число {firstNum} является квадратом числа {secondNum}.");
        }
        else
        {
            Console.WriteLine($"Число {firstNum} не является квадратом числа {secondNum}.");
        }
    }
    else
    {
        Console.WriteLine("Вы ничего не ввели в второе число!");
    }
}
else
{
    Console.WriteLine("Вы ничего не ввели в первое число!");
}
