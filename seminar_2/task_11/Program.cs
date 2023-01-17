/*
Задача №11
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int randNum = new Random().Next(100, 1000);

int firstNum = randNum / 100;
int lastNum = randNum % 100;
int number = firstNum * 10 + lastNum;

Console.WriteLine($"Было сгенерировано число: {randNum}.");
Console.WriteLine($"После удаления второго числа: {number}.");