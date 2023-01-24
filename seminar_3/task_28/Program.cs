/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

// -- Вычисление произведения числа -- //
int Calculate(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
// ------------------------------------ //

int PromptNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// --------------- Ввод данных -------------------- //
int number = PromptNumber("Введите число: ");
// ------------------------------------------------ //


// --------------- Вывод данных ------------------- //
int result = Calculate(number);
Console.WriteLine($"Произведение числа: {number} -> {result}");
// ------------------------------------------------ //