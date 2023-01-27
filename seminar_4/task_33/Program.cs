/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

bool IsNumberExists(int[] numArray, int find)
{
    int size = numArray.Length;
    for (int i = 0; i < size; i++)
    {
        int number = numArray[i];

        if (number == find)
        {
            return true;
        }
    }
    return false;
}


int[] GenerateArrayWithRandom(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        int randNum = new Random().Next(from, (to + 1));
        array[i] = randNum;
    }
    return array;
}


/* ----------- Генерируем массив ----------------------------- */
int[] numsArr = GenerateArrayWithRandom(16, -20, 20);
Console.WriteLine("[" + String.Join(", ", numsArr) + "]");
Console.WriteLine("В массиве число 15 -> " + IsNumberExists(numsArr, 15));
Console.WriteLine("В массиве число -4 -> " + IsNumberExists(numsArr, -4));
Console.WriteLine("В массиве число 8 -> " + IsNumberExists(numsArr, 8));
/* ----------------------------------------------------------- */