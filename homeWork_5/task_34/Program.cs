/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/* ------ Получение кол-ва чётных чисел ----------------- */
int GetEvenNumsCount(int[] numberArr)
{
    int count = 0;
    for (int i = 0; i < numberArr.Length; i++)
    {
        if (numberArr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
/* ------------------------------------------------------ */

/* ------ Вывод массива --------------------------------- */
string StringifyArray(int[] arr)
{
    string result = "[";
    int len = arr.Length;
    if (len == 0) return result;
    for (int i = 0; i < len - 1; i++)
    {
        result += arr[i] + ", ";
    }
    result += arr[len - 1] + "]";
    return result;
}
/* ------------------------------------------------------ */


/* ------ Генерация массива с рандомом ------------------ */
int[] GenerateArrayWithRandom(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, (to + 1));
    }
    return array;
}
/* ------------------------------------------------------ */


int[] numArray = GenerateArrayWithRandom(12, -999, 999);

Console.Write(StringifyArray(numArray) + " -> ");
Console.WriteLine(GetEvenNumsCount(numArray));