/*
Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/* ---------- Расчет степени от числа ----------- */
int CalculateNumberPower(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }
    return result;
}
/* ---------------------------------------------- */


/* ------ Получение данных от пользователя ------ */
int PromptNumber(string message)
{
    Console.Write(message);
    string line = Console.ReadLine();
    if (line == null || line == "")
    {
        Console.WriteLine("Внимание! Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(line);
}
/* ---------------------------------------------- */


int firstNumber = PromptNumber("Введите число которую надо возвести в степень: ");
int secondNumber = PromptNumber($"В который степень надо вовзести число {firstNumber}: ");

int result = CalculateNumberPower(firstNumber, secondNumber);
Console.WriteLine($"{secondNumber} степень числа {firstNumber} = {result}");