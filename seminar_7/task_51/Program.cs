/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/



int[,] GenerateMatrixWithRandom(int rows, int columns, int from, int to)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(from, (to + 1));
        }
    }
    return matrix;
}


int GetDiagonalSum(int[,] matrix)
{
    int result = 0;
    int len = matrix.GetLength(0);
    int len2 = matrix.GetLength(1);
    if (len2 > len) len = len2;
    for (int i = 0; i < len; i++)
    {
        result += matrix[i, i];
    }
    return result;
}

string StringifyMatrix(int[,] matrix)
{
    string strMatrix = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = matrix[i, j];
            strMatrix += number + "\t";
        }
        if (i != matrix.GetLength(0) - 1) strMatrix += "\n";
    }
    return strMatrix;
}

int[,] matrix = GenerateMatrixWithRandom(3, 4, 1, 10);

int diagonalSum = GetDiagonalSum(matrix);

Console.WriteLine($"{StringifyMatrix(matrix)} -> {diagonalSum}");