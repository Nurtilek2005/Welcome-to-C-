/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20.
*/

int CalculateNumArraySum(int[] numArray, bool positive)
{
    int sum = 0;
    int length = numArray.Length;
    for (int i = 0; i < length; i++)
    {
        int tempNum = numArray[i];
        if (tempNum > 0 && positive == true)
        {
            sum += tempNum;
        }
        if (tempNum < 0 && positive == false)
        {
            sum += tempNum;
        }
    }
    return sum;
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
int[] numsArr = GenerateArrayWithRandom(12, -9, 9);
Console.WriteLine("[" + String.Join(", ", numsArr) + "]");
/* ----------------------------------------------------------- */

/* ----------- Сумма положительных чисел --------------------- */
int positiveSum = CalculateNumArraySum(numsArr, true);
/* ----------------------------------------------------------- */

/* ----------- Сумма отрицательных чисел --------------------- */
int negativeSum = CalculateNumArraySum(numsArr, false);
/* ----------------------------------------------------------- */

/* ----------- Вывод пользователю результата ----------------- */
Console.WriteLine($"Сумма положительных чисел: {positiveSum}");
Console.WriteLine($"Сумма отрицательных чисел: {negativeSum}");
/* ----------------------------------------------------------- */