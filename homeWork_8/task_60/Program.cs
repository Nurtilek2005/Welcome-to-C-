/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = new int[4, 3, 5];

void Fill3DArrayNoRepeat(int[,,] array, int lowerBound = 1, int upperBound = 1000)
{
    Random random = new Random();
    int len1 = array.GetLength(0);
    int len2 = array.GetLength(1);
    int len3 = array.GetLength(2);
    int size = len1 * len2 * len3;
    int[] numbers = new int[size];
    while (size > 0)
    {
        int randNum = random.Next(lowerBound, upperBound + 1);
        if (numbers.Contains(randNum))
        {
            continue;
        }
        numbers[size - 1] = randNum;
        size--;
    }
    for (int i = 0; i < len1; i++)
    {
        for (int j = 0; j < len2; j++)
        {
            for (int k = 0; k < len3; k++)
            {
                array[i, j, k] = numbers[size++];
            }
        }
    }
}

void Print3DArray(int[,,] arr)
{
    int len1 = array.GetLength(0);
    int len2 = array.GetLength(1);
    int len3 = array.GetLength(2);
    for (int i = 0; i < len1; i++)
    {
        for (int j = 0; j < len2; j++)
        {
            for (int k = 0; k < len3; k++)
            {
                Console.Write("{0} ({1},{2},{3}) ".Trim(','), arr[i, j, k], i, j, k);
            }
            Console.WriteLine();
        }
    }
}

Fill3DArrayNoRepeat(array, 1, 100);
Print3DArray(array);