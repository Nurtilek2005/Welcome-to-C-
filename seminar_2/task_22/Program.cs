/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void FetchQuarters(int number)
{
    int currentNum = 1;
    Console.Write("Таблица квадратов чисел: ");
    while (currentNum <= number)
    {
        int quarter = currentNum * currentNum;
        Console.Write(quarter);
        if (currentNum < number) {
            Console.Write(", ");
        }
        currentNum++;
    }
}


int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = GetNum("Введите натуральное число: ");

FetchQuarters(number);