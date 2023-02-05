/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в 
массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

string StrRepeat(string value, int count)
{
    string result = value;
    while(count > 0) {
        result += value;
        count--;
    }
    return result;
}

int GetNumberLength(int number)
{
    int length = 1;
    while (number >= 10)
    {
        number /= 10;
        length++;
    }
    return length;
}


int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

string StringifyMatrix(int[,] matrix)
{
    string strMatrix = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = matrix[i, j];
            int len = GetNumberLength(number);
            strMatrix += number + StrRepeat(" ", len);
        }
        if (i != matrix.GetLength(0) - 1) strMatrix += "\n";
    }
    return strMatrix;
}

int[,] matrix = FillMatrix(3, 4);

Console.WriteLine(StringifyMatrix(matrix));