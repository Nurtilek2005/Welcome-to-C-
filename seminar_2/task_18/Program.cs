/* 
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void FetchCoordinates(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("Диапазон возможных точек в X: 1, 2, 3 ...");
        Console.WriteLine("Диапазон возможных точек в Y: 1, 2, 3 ...");
    }
    if (quarter == 2)
    {
        Console.WriteLine("Диапазон возможных точек в X: -1, -2, -3 ...");
        Console.WriteLine("Диапазон возможных точек в Y: 1, 2, 3 ...");
    }
    if (quarter == 3)
    {
        Console.WriteLine("Диапазон возможных точек в X: -1, -2, -3 ...");
        Console.WriteLine("Диапазон возможных точек в Y: -1, -2, -3 ...");
    }
    if (quarter == 4)
    {
        Console.WriteLine("Диапазон возможных точек в X: 1, 2, 3 ...");
        Console.WriteLine("Диапазон возможных точек в Y: -1, -2, -3 ...");
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int quarter = GetNum("Введите номер четверти: ");

FetchCoordinates(quarter);