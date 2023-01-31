/*
Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
*/


/* --------------------------------------------- */
string IsRightTriangle(int a, int b, int c)
{
    int result = a + b;
    if (a * c <= a * b + b * c) return "не может";
    return "может";
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

int number1 = PromptNumber("Введите первое число: ");
int number2 = PromptNumber("Введите второе число: ");
int number3 = PromptNumber("Введите третье число: ");

string result = IsRightTriangle(number1, number2, number3);
Console.WriteLine($"Триугольник с длинами: {number1}, {number2}, {number3} -> {result}");

/* --------------------------------------------- */