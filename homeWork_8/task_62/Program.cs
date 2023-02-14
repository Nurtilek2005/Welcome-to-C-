/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using MatrixMaster;
using System.Globalization;

Matrix<int> matrix = new Matrix<int>(4, 4);

void SpiralFillMatrix(Matrix<int> matrix, int direction = 1, int i = 0, int row = 0, int col = 0, int k = 0)
{
    int rows = matrix.GetRowsLength();
    int columns = matrix.GetColumnsLength();
    int size = rows * columns;
    if (i == size) return;
    Console.Write($"{i}: ({row}, {col}) -> ");
    Console.WriteLine($"direction: {direction}");
    matrix[row, col] = i;
    switch (direction)
    {
        case 1:
            if (col == columns - 1 - k)
            {
                direction = 2;
                break;
            }
            col++;
            break;
        case 2:
            if (row == rows - 1 - k)
            {
                direction = 3;
                break;
            }
            row++;
            break;
        case 3:
            if (col - k == 0)
            {
                direction = 4;
                break;
            }
            col--;
            break;
        case 4:
            if (row - k == 0)
            {
                direction = 1;
                break;
            }
            if (matrix[row, col] != 0)
            {
                k++;
            }
            row--;
            break;
    }
    SpiralFillMatrix(matrix, direction, i + 1, row, col, k);
}

void PrettyPrintMatrix(Matrix<int> matrix, int width = 3)
{
    for (int i = 0; i < matrix.GetRowsLength(); i++)
    {
        for (int j = 0; j < matrix.GetColumnsLength(); j++)
        {
            string pretty = String.Empty;
            int len = width - $"{matrix[i, j]}".Length;
            while (len > 0)
            {
                pretty = "0" + pretty;
                len--;
            }
            Console.Write(pretty + matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

SpiralFillMatrix(matrix);
PrettyPrintMatrix(matrix, 2);