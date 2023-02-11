/*
Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void PrintNumbers1(int num, int currentNum = 1)
{
    if (currentNum == num) {
        Console.WriteLine(currentNum);
        return;
    }
    Console.Write(currentNum + ", ");
    PrintNumbers1(num, currentNum + 1);
}


void PrintNumbers2(int num)
{
    int currentNum = 1; 
    if (currentNum == num) {
        Console.WriteLine(currentNum);
        return;
    }
    Console.Write(currentNum + ", ");
    PrintNumbers2(currentNum++);
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

int number = PromptNumber("Введите число N: ");

PrintNumbers1(number);