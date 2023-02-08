/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

using MatrixMaster;

int PromptNumber(string message)
{
    int number;
    string? line;
    while (true)
    {
        Console.WriteLine(message);
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
        catch(FormatException)
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

Matrix<int> matrix = new Matrix<int>(3, 7);
matrix.RandomNumbers(1, 9);
Console.WriteLine(matrix);

int row = PromptNumber("Input row index for get value: ");
int column = PromptNumber("Input column index for get value: ");

if (!matrix.IsPointExists(row, column))
{
    Console.WriteLine("Value isn't exists!");
}
else
{
    int value = matrix.GetValue(row, column);
    Console.WriteLine($"Value is exists -> {value}");
}