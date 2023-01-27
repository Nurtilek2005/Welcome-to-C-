/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int GetNumberLength(int number)
{
    int length = 1;
    while (number >= 10)
    {
        number /= 10;
        length++;
    }
    return length;
}


int GetLenNumbersCount(int[] numArray, int len)
{
    int count = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if (GetNumberLength(numArray[i]) == len) {
            count++;
        }
    }
    return count;
}


int[] GenerateArrayWithRandom(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, (to + 1));
    }
    return array;
}


int[] numsArr = GenerateArrayWithRandom(123, 0, 999);
Console.Write("[" + String.Join(", ", numsArr) + "] -> ");
Console.WriteLine(GetLenNumbersCount(numsArr, 2));