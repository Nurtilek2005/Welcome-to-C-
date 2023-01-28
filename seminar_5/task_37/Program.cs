/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int RoundNum(double num)
{
    double roundedNum = Math.Round((double)num);
    return Convert.ToInt32(roundedNum);
}

string CalculateNumbersInArray(int[] numsArray)
{
    int size = numsArray.Length;
    string result = String.Empty;
    for (int i = 0; i < RoundNum((double) size / 2); i++)
    {
        int firstNum = numsArray[i];
        int secondNum = numsArray[(size - i) - 1];
        result += firstNum * secondNum + " ";
    }
    return result;
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


int[] numsArr = GenerateArrayWithRandom(7, 0, 13);
Console.Write("[" + String.Join(", ", numsArr) + "] -> ");
Console.WriteLine(CalculateNumbersInArray(numsArr));