/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] InvertArray(int[] array)
{
    int[] revers = new int[array.Length];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        revers[i] = array[^(i + 1)];
    }
    return revers;
}

int[] GenerateArray(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, (to + 1));
    }
    return array;
}

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

/* Запрос кол-ва элементов в массиве */
int valuesCount = PromptNumber("Введите кол-во элементов в массиве: ");

/* Создание массива */
int[] numArray = GenerateArray(valuesCount, 0, 9);

/* Перевернем массив */
int[] reversedArray = InvertArray(numArray);

Console.Write($"[{String.Join(" ", numArray)}] -> ");
Console.WriteLine($"[{String.Join(" ", reversedArray)}]");