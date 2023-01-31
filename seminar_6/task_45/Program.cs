/*
Задача 45: Напишите программу, которая будет 
создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
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

int valuesCount = PromptNumber("Введите кол-во элементов в массиве: ");

int[] numArray = GenerateArray(valuesCount, 0, 9);
int[] copyArray = CopyArray(numArray);

Console.Write($"[{String.Join(" ", numArray)}] -> ");
Console.WriteLine($"[{String.Join(" ", copyArray)}]");