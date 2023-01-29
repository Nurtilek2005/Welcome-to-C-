/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/* ---- Разница между 2 чисел ---------------------------- */
int DiffBetweenNumbers(int number1, int number2)
{
    if (number1 < number2)
    {
        int tempNum = number1;
        number1 = number2;
        number2 = tempNum;
    }
    return number1 - number2;
}
/* ------------------------------------------------------- */

/* ---- Получение минимального или максимального числа --- */
int GetMinOrMaxValueInArr(int[] numberArr, bool max)
{
    int tempMin = numberArr[0];
    int tempMax = numberArr[0];
    for (int i = 1; i < numberArr.Length; i++)
    {
        int tempNum = numberArr[i];
        if (tempMin > tempNum) tempMin = tempNum;
        if (tempMax < tempNum) tempMax = tempNum;
    }
    if (max == false) return tempMin;
    return tempMax;
}
/* ------------------------------------------------------- */

/* ---- Вывод массива ------------------------------------ */
string StringifyArray(int[] arr)
{
    string result = "[";
    int len = arr.Length;
    if (len == 0) return result + "]";
    for (int i = 0; i < len - 1; i++)
    {
        result += arr[i] + ", ";
    }
    result += arr[len - 1] + "]";
    return result;
}
/* ------------------------------------------------------- */

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

// В примере использован этот массив:
// int[] numberArray = new int[]{3, 7, 22, 2, 78}; // 76;
int[] numberArray = GenerateArrayWithRandom(5, -10, 90);
int maxNumber = GetMinOrMaxValueInArr(numberArray, true);
int minNumber = GetMinOrMaxValueInArr(numberArray, false);
int diffBetweenNums = DiffBetweenNumbers(minNumber, maxNumber);
Console.WriteLine($"{StringifyArray(numberArray)} -> {diffBetweenNums}");