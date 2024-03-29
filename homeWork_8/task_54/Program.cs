﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using MatrixMaster;

Matrix<int> matrix = new Matrix<int>(3, 4);
matrix.RandomNumbers(1, 9);

Console.WriteLine(matrix + "\n--------------");
Console.WriteLine(matrix.GetSortedNums(true));