/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

void PrintNumbersBetween(int fromNum, int toNum)
{
    if (fromNum == toNum)
    {
        Console.WriteLine(fromNum);
        return;
    }
    Console.Write(fromNum + ", ");
    PrintNumbersBetween(fromNum + 1, toNum);
}

int PromptNumber(string message)
{
    int number;
    string? line;
    while (true)
    {
        Console.Write(message);
        line = Console.ReadLine();
        if(line == null || line.Trim() == "")
        {
            Console.Write("Вы ничего не ввели!");
            continue;
        }
        return int.Parse(line);
    }
}

int numberM = PromptNumber("Введите число M: ");
int numberN = PromptNumber("Введите число N: ");

PrintNumbersBetween(numberM, numberN);