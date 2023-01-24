/*
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

/* --- Расчет суммы цифр в массиве --------- */
int CalculateNumArraySum(int[] array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        result += array[i];
    }
    return result;
}
/* ------------------------------------------ */


/* --- Расчет степени от числа -------------- */
int CalculateNumberPower(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }
    return result;
}
/* ------------------------------------------ */


/* --- Получение кол-во цифр в числе -------- */
int GetNumbersCount(int number)
{
    int count = 1;
    for (int i = number; i >= 10; i /= 10)
    {
        count++;
    }
    return count;
}
/* ------------------------------------------ */


/* --- Получение массива цифр от числа ------ */
int[] ConvertNumbersToArray(int number)
{
    int length = GetNumbersCount(number);
    int[] array = new int[length];
    for (int i = 1; i <= length; i++)
    {
        int result1 = number % CalculateNumberPower(10, i);
        int result2 = CalculateNumberPower(10, i - 1);
        int tempNumber = result1 / result2;
        array[length - i] = tempNumber;
    }
    return array;
}
/* ------------------------------------------ */


/* --- Получение данных от пользователя ----- */
int PromptNumber(string message)
{
    Console.Write(message);
    string line = Console.ReadLine();
    if (line == null || line == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(line);
}
/* ------------------------------------------ */


int number = PromptNumber("Введите число из которого нужно получить сумму цифр: ");
Console.Write($"Сумма цифр числа {number} составляет: ");
int[] numArray = ConvertNumbersToArray(number);
int result = CalculateNumArraySum(numArray);
Console.WriteLine(result);