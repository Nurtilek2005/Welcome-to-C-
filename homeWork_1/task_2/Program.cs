/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

// -- # -- # -- # Основной # -- # -- # -- //

string? strNum1, strNum2;
int min = 0, max = 0;

Console.Write("Введие первое число: ");
strNum1 = Console.ReadLine();

if (strNum1 != null && strNum1.Trim() != "")
{
    int number1 = int.Parse(strNum1);

    Console.Write("Введие второе число: ");
    strNum2 = Console.ReadLine();

    if (strNum2 != null && strNum2.Trim() != "")
    {
        int number2 = int.Parse(strNum2);

        if (number1 > number2)
        {
            max = number1;
            min = number2;
        }
        else
        {
            min = number1;
            max = number2;
        }
        Console.Write("Минимальное число: ");
        Console.WriteLine(min);
        Console.Write("Максимальное число: ");
        Console.WriteLine(max);
    }
    else
    {
        Console.WriteLine("Ваше 2 число - пустое!");
    }
}
else
{
    Console.WriteLine("Ваше 1 число - пустое!");
}

// Просто я немного изучал ранее C# //
// -- # -- # -- # Дополнительный код # -- # -- # -- //

/*
string? strNum1 = null, strNum2 = null;
int number1 = 0, number2 = 0;
int min = 0, max = 0;

while (number1 == 0)
{
    Console.Write("Введие первое число: ");
    strNum1 = Console.ReadLine();

    if (strNum1 == null || strNum1.Trim() == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        continue;
    }

    try
    {
        int.Parse(strNum1);
    }
    catch (OverflowException)
    {
        Console.WriteLine("Слишком большое значение для числа!");
        continue;
    }
    catch (FormatException)
    {
        Console.WriteLine("Вы ввели что то, что не число!");
        continue;
    }
    catch
    {
        Console.WriteLine("Что ты натворил? Ааааа..");
        continue;
    }
    number1 = int.Parse(strNum1);
}

while (number2 == 0)
{

    Console.Write("Введие второе число: ");
    strNum2 = Console.ReadLine();

    if (strNum2 == null || strNum2.Trim() == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        continue;
    }

    try
    {
        int.Parse(strNum2);
    }
    catch (System.OverflowException)
    {
        Console.WriteLine("Слишком большое значение для числа!");
        continue;
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Вы ввели что то, что не число!");
        continue;
    }
    catch
    {
        Console.WriteLine("Что ты натворил? Ааааа..");
        continue;
    }
    number2 = int.Parse(strNum2);
}

if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    min = number1;
    max = number2;
}
Console.Write("Минимальное число: ");
Console.WriteLine(min);
Console.Write("Максимальное число: ");
Console.WriteLine(max);
*/