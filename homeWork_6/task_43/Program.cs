/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


/* --- Получение данных от пользователя ----------- */
string GetCrossPoint(int b1, int k1, int b2, int k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return $"({x}; {y})";
}
/* ------------------------------------------------ */

/* --- Получение данных от пользователя ----------- */
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
/* ------------------------------------------------ */

int b1 = PromptNumber("Введите значение b1: ");
int k1 = PromptNumber("Введите значение k1: ");
int b2 = PromptNumber("Введите значение b2: ");
int k2 = PromptNumber("Введите значение k2: ");

/* ------------------------------------------------ */

Console.Write("b1 = " + b1 + ", ");
Console.Write("k1 = " + k1 + ", ");
Console.Write("b2 = " + b2 + ", ");
Console.Write("k2 = " + k2 + "; -> ");
Console.WriteLine(GetCrossPoint(b1, k1, b2, k2));