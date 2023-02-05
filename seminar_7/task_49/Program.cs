/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

string StrRepeat(string value, int count)
{
    string result = value;
    while (count > 0)
    {
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

int[,] DuplicateMatrix(int[,] origin)
{
    int rows = origin.GetLength(0);
    int columns = origin.GetLength(1);
    int[,] duplicate = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            duplicate[i, j] = origin[i, j];
        }
    }
    return duplicate;
}


int[,] PowMatrixOddIndexElems(int[,] matrix)
{
    int[,] powMatrix = DuplicateMatrix(matrix);
    for (int i = 0; i < powMatrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < powMatrix.GetLength(1); j += 2)
        {
            double powNum = Math.Pow(powMatrix[i, j], 2);
            powMatrix[i, j] = Convert.ToInt32(powNum);
        }
    }
    return powMatrix;
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
            strMatrix += number + "\t";
        }
        if (i != matrix.GetLength(0) - 1) strMatrix += "\n";
    }
    return strMatrix;
}

int[,] matrix = GenerateMatrixWithRandom(3, 4, 10, 10);

int[,] powMatrix = PowMatrixOddIndexElems(matrix);

Console.WriteLine(StringifyMatrix(matrix));
Console.WriteLine("------------------------");
Console.WriteLine(StringifyMatrix(powMatrix));
