/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии. 
A = 3; B = 5 -> 243 (3⁵) 
A = 2; B = 3 -> 8
*/

int PowerNumber(int number, int power)
{
    if (power <= 1) return number;
    return number * PowerNumber(number, power - 1);
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

int number = PromptNumber("Введите число: ");
int power = PromptNumber("Введите степень: ");

Console.WriteLine($"{number}^{power} -> {PowerNumber(number, power)}");