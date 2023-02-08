/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using MatrixMaster;

/* -- Расчет среднее арифметическое в массиве -- */
double CalculateNumsAvg(int[] numArr)
{
    double result = 0;
    for (int i = 0; i < numArr.Length; i++)
    {
        result += numArr[i];
    }
    return Math.Round(result / numArr.Length, 1);
}
/* ---------------------------------------------- */

/* -- Вывод массива ----------------------------- */
string StringifyArray(int[] arr)
{
    string result = "[";
    if (arr.Length == 0) return result + "]";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        result += arr[i] + ", ";
    }
    result += arr[arr.Length - 1] + "]";
    return result;
}
/* ---------------------------------------------- */

Matrix<int> matrix = new Matrix<int>(3, 4);
matrix.RandomNumbers(1, 9);
Console.WriteLine(matrix);
Console.WriteLine("----------------------------");
for (int i = 0; i < matrix.GetColumnsLength(); i++)
{
    int[] colArray = matrix.GetColumnArray(i);
    Console.Write(i + ": " + StringifyArray(colArray));
    Console.WriteLine(" -> " + CalculateNumsAvg(colArray));
}