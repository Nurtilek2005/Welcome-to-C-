/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 // тут ошибка. должно быть 4 вроде
*/

/* 
 * Простите если очень много костылей.
 * Тут я применил большой процент своего знания.
 * Думал ещё разделить команды на отдельные функции.
 * Но думюа это уже слишком будет уже.
 * Стараюсь всегда улучшать свой код.
 * Спасибо за проверку!
*/


/* ---- Генерация массива с рандомом --------------------- */
int[] GenerateArrayWithRandom(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, (to + 1));
    }
    return array;
}
/* ------------------------------------------------------- */

/* ------------------------------------------------------- */
int GetNaturalNumbersCount(List<int> numList)
{
    int count = 0;
    for (int i = 0; i < numList.Count; i++)
    {
        if (numList[i] > 0) count++;
    }
    return count;
}
/* ------------------------------------------------------- */

void PrintHelp()
{
    Console.WriteLine("Возможные команды: ");
    Console.WriteLine("end, count - для выхода программы.");
    Console.WriteLine("rand, random - для рандом вычисления.");
    Console.WriteLine("example1, ex1 - для вычисления 1 примера");
    Console.WriteLine("example2, ex2 - для вычисления 2 примера");
}

List<int> numbersList = new List<int>();

while (true)
{
    Console.Write("Введите число или команду: ");
    string? line = Console.ReadLine();

    if (line == null || line.Trim() == String.Empty)
    {
        Console.WriteLine("Вы ничего не ввели!");
        continue;
    }
    if (line.ToLower() == "help" || line.ToLower() == "?")
    {
        PrintHelp();
        continue;
    }
    if (line.ToLower() == "example1" || line.ToLower() == "ex1")
    {
        numbersList.AddRange(new int[] { 0, 7, 8, -2, -2 });
        break;
    }
    if (line.ToLower() == "example2" || line.ToLower() == "ex2")
    {
        numbersList.AddRange(new int[] { 1, -7, 567, 89, 223 });
        break;
    }
    if (line.ToLower() == "random" || line.ToLower() == "rand")
    {
        numbersList.AddRange(GenerateArrayWithRandom(5, -567, 567));
        break;
    }
    if (line.ToLower() == "end" || line.ToLower() == "count")
    {
        Console.WriteLine("Вычисление...");
        break;
    }

    try
    {
        int number = int.Parse(line);
        numbersList.Add(number);
    }
    catch (FormatException)
    {
        Console.WriteLine($"'{line}' - не является числом или командой!");
        Console.WriteLine("Введите help что бы узнать команды!");
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ваше число слишком большое!");
        continue;
    }
    Console.WriteLine($"[{String.Join(", ", numbersList)}]");
}

Console.WriteLine($"{String.Join(", ", numbersList)} -> {GetNaturalNumbersCount(numbersList)}");