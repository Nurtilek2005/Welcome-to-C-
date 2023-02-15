/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int[] GetNumbersBetween(int from, int to, int[]? numbers = null, int i = 0)
{
    if (numbers == null) 
    {
        int len = Math.Abs(from - to);
        numbers = new int[len + 1];
    }
    numbers[i++] = from;
    if (from > to) from--; else from++;
    if (numbers != null && i == numbers.Length) return numbers;
    return GetNumbersBetween(from, to, numbers, i);
}

void PrintArray(int[] array, int i = 0)
{
    if (i == 0) Console.Write("[");
    if (array.Length < 1)
    {
        Console.WriteLine("]");
        return;
    }
    if (i == array.Length - 1)
    {
        Console.WriteLine("{0}]", array[i]);
        return;
    }
    Console.Write("{0}, ", array[i++]);
    PrintArray(array, i);
}

int PromptNumber(string message)
{
    int number;
    string? line;
    while (true)
    {
        Console.Write(message);
        line = Console.ReadLine();

        if (line == null || line.Trim() == "")
        {
            Console.WriteLine("Your input is empty!");
            continue;
        }
        try
        {
            number = int.Parse(line);
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Your input isn't number format!");
            continue;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Your input number is too long!");
            continue;
        }
    }
    return number;
}

int number = PromptNumber("Input number N: ");

int[] numbersBetween = GetNumbersBetween(number, 1);
PrintArray(numbersBetween);