/*
Задача №1
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

int randNumber = new Random().Next(10, 100);
int number1 = randNumber / 10;
int number2 = randNumber % 10;

int max = number1;
if (number2 > max) max = number2;

Console.Write("Max number of numbers: ");
Console.Write(number1 + ", " + number2);
Console.WriteLine(" - " + max + "!");

