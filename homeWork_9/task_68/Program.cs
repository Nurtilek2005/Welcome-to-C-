/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM > 0 && numberN == 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    int res = Akkerman(numberM, numberN - 1);
    return Akkerman(numberM - 1, res);
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

int akkerman = Akkerman(numberM, numberN);
Console.WriteLine($"A({numberM}, {numberN}) = {akkerman}");