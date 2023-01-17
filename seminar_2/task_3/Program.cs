/*
Задача №3
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

string? firstNumStr = null;
string? secondNumStr = null;

Console.Write("Введите первое число: ");
firstNumStr = Console.ReadLine();
if (firstNumStr != null && firstNumStr != "")
{
    int firstNum = int.Parse(firstNumStr);
    Console.Write("Введите второе число: ");
    secondNumStr = Console.ReadLine();
    if (secondNumStr != null && secondNumStr != "")
    {
        int secondNum = int.Parse(secondNumStr);
        int res = firstNum % secondNum;
        if (res == 0) {
            Console.WriteLine($"Число {firstNum} кратный числу {secondNum}");
        } else {
            Console.WriteLine($"Число {firstNum} не кратный числу {secondNum}. Остаток: {res}");
        }
    }
    else
    {
        Console.WriteLine("Вы ничего не ввели в второе число!");
    }

}
else
{
    Console.WriteLine("Вы ничего не ввели в первое число!");
}
