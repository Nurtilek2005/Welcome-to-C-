/* 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

// Формула для расстояния d между двумя точками, координаты которых (x1, y1) и (x2, y2)
// 

void Distance(double x1, double y1, double x2, double y2)
{
    Console.Write("Дистанция между координатами: ");
    double result1 = (x2 - x1) * (x2 - x1);
    double result2 = (y2 - y1) * (y2 - y1);
    double result = Math.Sqrt(result1 + result2);
    Console.Write(Math.Round(result, 2));
}


double GetDouble(string text)
{
    Console.Write(text);
    double num = double.Parse(Console.ReadLine());
    return num;
}

// Ввод данных от пользователя первой и второй точки
double x1 = GetDouble("Введите значение X первой точки: ");
double y1 = GetDouble("Введите значение Y первой точки: ");
double x2 = GetDouble("Введите значение X второй точки: ");
double y2 = GetDouble("Введите значение Y второй точки: ");

Distance(x1, y1, x2, y2);