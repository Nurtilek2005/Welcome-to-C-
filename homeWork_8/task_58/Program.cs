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

Matrix<int> matrix1 = new Matrix<int>(3, 3);
Matrix<int> matrix2 = new Matrix<int>(3, 3);

matrix1.RandomNumbers(1, 9);
matrix2.RandomNumbers(1, 9);

Console.WriteLine("- 1 -");
Console.WriteLine(matrix1);
Console.WriteLine("- 2 -");
Console.WriteLine(matrix2);
Console.WriteLine("-----");
Console.WriteLine("-----");