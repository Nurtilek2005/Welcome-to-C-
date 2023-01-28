/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/* ------ Расчет суммы чисел в массиве ------------------ */
int CalculateNumsSum(int[] numArr)
{
    int result = 0;
    for (int i = 0; i < numArr.Length; i++)
    {
        result += numArr[i];
    }
    return result;
}
/* ------------------------------------------------------ */

/* ------ Фильтрация массива на нечётных позициях ------- */
int[] FilterArrayOddValue(int[] numberArr)
{
    int length = numberArr.Length;
    int[] filterArr = new int[length / 2];
    for (int i = 1; i < length; i += 2)
    {
        filterArr[i / 2] = numberArr[i];
    }
    return filterArr;
}
/* ------------------------------------------------------ */

/* ------ Вывод массива --------------------------------- */
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


int[] numArray = GenerateArrayWithRandom(5, -10, 90);
int[] oddNumArray = FilterArrayOddValue(numArray);

Console.Write(StringifyArray(numArray) + " -> ");
Console.WriteLine(CalculateNumsSum(oddNumArray));