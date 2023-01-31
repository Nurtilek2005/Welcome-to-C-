/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

/* --------------------------------------------- */
int CalcFibonacci(int number)
{
    int temp1 = 0;
    int temp2 = 0;
    int result = 1;
    if (number == 0) return 0;
    for (int i = 2; i <= number; i++)
    {
        temp2 = temp1 + result;
        temp1 = result;
        result = temp2;
    }
    return result;
}
/* --------------------------------------------- */

/* --------------------------------------------- */
void Fibonacci(int num)
{
    for (int n = 0; n <= num; n++)
    {
        Console.Write(CalcFibonacci(n) + " ");
    }
}
/* --------------------------------------------- */

/* --------------------------------------------- */
int PromptNumber(string message)
{
    Console.Write(message);
    string? line = Console.ReadLine();
    if (line == null || line == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(line);
}
/* --------------------------------------------- */

int number = PromptNumber("Введите число: ");
Fibonacci(number);
