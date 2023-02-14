/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using MatrixMaster;

Matrix<int> CompositeMatrix(Matrix<int> matrix1, Matrix<int> matrix2)
{
    int rows = matrix1.GetRowsLength();
    int rows2 = matrix2.GetRowsLength();
    int columns = matrix1.GetColumnsLength();
    int columns2 = matrix2.GetColumnsLength();
    if (rows2 > rows)
    {
        int temp = rows2;
        rows2 = rows;
        rows = temp;
    }
    if (columns2 > columns)
    {
        int temp = columns2;
        columns2 = columns;
        columns = temp;
    }
    Matrix<int> result = new Matrix<int>(rows, columns);
    for (int row = 0; row < rows2; row++)
    {
        for (int column = 0; column < columns2; column++)
        {
            for (int i = 0; i < rows2; i++)
            {
                int value1 = matrix1[row, i];
                int value2 = matrix2[i, column];
                int composite = value1 * value2;
                result[row, column] += composite;
            }
        }
    }
    return result;
}

Matrix<int> matrix1 = new Matrix<int>(3, 3);
Matrix<int> matrix2 = new Matrix<int>(3, 3);

matrix1.RandomNumbers(1, 9);
matrix2.RandomNumbers(1, 9);

if (matrix1.GetRowsLength() != matrix2.GetRowsLength())
{
    Console.WriteLine("Внимание! Ваши матрицы не совпадают по длине строк!");
}
if (matrix1.GetColumnsLength() != matrix2.GetColumnsLength())
{
    Console.WriteLine("Внимание! Ваши матрицы не совпадают по длине столбцам!");
}

Matrix<int> result = CompositeMatrix(matrix1, matrix2);

Console.WriteLine("- 1 -");
Console.WriteLine(matrix1);
Console.WriteLine("- 2 -");
Console.WriteLine(matrix2);
Console.WriteLine("-----");
Console.WriteLine(result);
Console.WriteLine("-----");
