/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

/* --------------------------------------------- */
string ConvertToBin(int num) {
    return Convert.ToString(num, 2);
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

int number = PromptNumber("Введите число чтобы преобразовать десятичное число в двоичное: ");

Console.WriteLine($"Число {number} в двоичной системе равна -> {ConvertToBin(number)}");

