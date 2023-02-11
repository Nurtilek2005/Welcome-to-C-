/*

*/

int GetNumbersSum(int num)
{
    if (num <= 10) return num;
    int result = GetNumbersSum(num / 10);
    return result + num % 10;
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

Console.WriteLine($"{number} -> {GetNumbersSum(number)}");