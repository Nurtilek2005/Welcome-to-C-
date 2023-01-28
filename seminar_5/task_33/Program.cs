/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

string IsNumberExists(int[] numArray, int find)
{
    for (int i = 0; i < numArray.Length; i++)
    {
        if (numArray[i] == find)
        {
            return "Да";
        }
    }
    return "Нет";
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


/* ----------- Генерируем массив ----------------------------- */
int[] numsArr = GenerateArrayWithRandom(16, 0, 10);
Console.WriteLine("[" + String.Join(", ", numsArr) + "]");
Console.WriteLine("В массиве число 5 -> " + IsNumberExists(numsArr, 5));
Console.WriteLine("В массиве число 1 -> " + IsNumberExists(numsArr, 1));
Console.WriteLine("В массиве число 8 -> " + IsNumberExists(numsArr, 8));
/* ----------------------------------------------------------- */