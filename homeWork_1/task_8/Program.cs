/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

string? strNum = null;
int number = 0;

Console.WriteLine("Введите натуральное число: ");
strNum = Console.ReadLine();

if (strNum != null && strNum != "")
{
    number = int.Parse(strNum);
    if (number > 0)
    {
        int currentNum = 1;
        while (currentNum <= number)
        {
            if ((currentNum % 2) == 0)
            {
                Console.Write(currentNum);
                if (currentNum < (number - 1)) {
                    Console.Write(", ");
                }
            }
            currentNum++;
        }
    }
    else
    {
        Console.WriteLine("Ваше число не натуральное!");
    }
}
else
{
    Console.WriteLine("Вы ничего не ввели!");
}