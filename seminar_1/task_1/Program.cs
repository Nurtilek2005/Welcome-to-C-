/*

Задача №3
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница

*/

Console.Write("Введите число");
string line = Console.ReadLine();
if (line == null)
{
    Console.WriteLine("Вы не ввели число!");
}
else
{
    try
    {
        int number = int.Parse(line);
    }
    catch
    {
        Console.WriteLine("Ваше значение не является числом!");
        throw;
    }
    finally
    {
    }
}
