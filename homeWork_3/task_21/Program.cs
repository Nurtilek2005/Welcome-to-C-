/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string promptText)
{
    Console.Write(promptText + ": ");
    string? strNum = Console.ReadLine();
    if (strNum == null || strNum.Trim() == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(strNum);
}

void Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int resultX = (x2 - x1) * (x2 - x1);
    int resultY = (y2 - y1) * (y2 - y1);
    int resultZ = (z2 - z1) * (z2 - z1);
    int result = resultX + resultY + resultZ;
    double distance = Math.Round(Math.Sqrt(result), 2);
    Console.Write($"Расстояние между точками (X: {x1}, Y: {y1}, Z: {z1}) ");
    Console.Write($"и точками (X: {x2}, Y: {y2}, Z: {z2}): {distance}");
}

int x1 = GetNumber("Введите координату X первой точки");
int y1 = GetNumber("Введите координату Y первой точки");
int z1 = GetNumber("Введите координату Z первой точки");
int x2 = GetNumber("Введите координату X второй точки");
int y2 = GetNumber("Введите координату Y второй точки");
int z2 = GetNumber("Введите координату Z второй точки");

Distance3D(x1, y1, z1, x2, y2, z2);