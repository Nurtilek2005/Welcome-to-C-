/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

string? strNum1, strNum2, strNum3;
int number1, number2, number3;

Console.Write("Введите первое число: ");
strNum1 = Console.ReadLine();
if (strNum1 != null && strNum1.Trim() != "")
{
    number1 = int.Parse(strNum1);
    Console.Write("Введите второе число: ");
    strNum2 = Console.ReadLine();
    if (strNum2 != null && strNum2.Trim() != "")
    {
        number2 = int.Parse(strNum2);
        Console.Write("Введите третье число: ");
        strNum3 = Console.ReadLine();
        if (strNum3 != null && strNum3.Trim() != "")
        {
            int max = number1;
            number3 = int.Parse(strNum3);
            if (number2 > max) max = number2;
            if (number3 > max) max = number3;
            Console.Write("Максимальное число: ");
            Console.WriteLine(max);
        }
        else
        {
            Console.WriteLine("Ваше третье число - пустое!");
        }
    }
    else
    {
        Console.WriteLine("Ваше второе число - пустое!");
    }
}
else
{
    Console.WriteLine("Ваше первое число - пустое!");
}