/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using MatrixMaster;

/* -- Расчет среднее арифметическое в массиве -- */
int CalculateNumsSum(int[] numArr)
{
    int result = 0;
    for (int i = 0; i < numArr.Length; i++)
    {
        result += numArr[i];
    }
    return result;
}
/* ---------------------------------------------- */

int GetMinNumSumRow(Matrix<int> matrix)
{
    int rows = matrix.GetRowsLength();
    int tempMinSumIndex = rows;
    int[]lastRowArr = matrix.GetRowArray(rows - 1);
    int tempMinRow = CalculateNumsSum(lastRowArr);
    for (int i = 0; i < rows; i++)
    {
        int[] rowArr = matrix.GetRowArray(i);
        int rowSum = CalculateNumsSum(rowArr);
        Console.WriteLine($"{i + 1} : {rowSum}");
        if (tempMinRow > rowSum)
        {
            tempMinRow = rowSum;
            tempMinSumIndex = i + 1;
        }
    }
    return tempMinSumIndex;
}

Matrix<int> matrix = new Matrix<int>(3, 4);
matrix.RandomNumbers(1, 9);

Console.WriteLine(matrix + "\n--------------");
Console.WriteLine(GetMinNumSumRow(matrix));