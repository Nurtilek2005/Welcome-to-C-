/*
Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"

*/

string? strNum = null;
while (strNum == null)
{
    Console.Write("Введите натуральное число: ");
    strNum = Console.ReadLine();
    if (strNum == null)
    {
        Console.WriteLine("Вы не ввели число!");
        strNum = null;
        continue;
    }
    int number = int.Parse(strNum);
    if (number < 1)
    {
        Console.WriteLine("Вы ввели не натуральное число!");
        strNum = null;
        continue;
    }
    int tempNum = 0 - number;
    while (tempNum <= number)
    {
        Console.Write(tempNum);
        if (tempNum < number)
        {
            Console.Write(", ");
        }
        tempNum++;
    }
    break;
}