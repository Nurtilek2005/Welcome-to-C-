/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumbersSum(int[] numArray, int i = 0)
{
    int result = 0;
    if (numArray.Length == i) return result;
    return result + numArray[i] + GetNumbersSum(numArray, i + 1);
}

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

int numberM = PromptNumber("Input number M: ");
int numberN = PromptNumber("Input number N: ");

int[] numbersBetween = GetNumbersBetween(numberM, numberN);
int numbersSum = GetNumbersSum(numbersBetween);
PrintArray(numbersBetween);
Console.WriteLine(numbersSum);