/*
Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* --- Вывод массива ------------------------ */
void PrintArray(int[] arr)
{
    int len = arr.Length;
    if (len == 0) return;
    Console.Write("[");
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[len - 1] + "]");
}
/* ------------------------------------------ */


/* ----- Заполнение массива рандомными цифрами ----- */
void FillArrayWithRandom(int[] array, int from, int to)
{
    // to == 1; Random -> 0, 0;
    int random = 0;
    for (int i = 0; i < array.Length; i++)
    {
        random = new Random().Next(from, (to + 1));
        array[i] = random;
    }
}
/* ------------------------------------------------ */


/* --- Получение данных от пользователя ----------- */
int PromptNumber(string message)
{
    Console.Write(message);
    string line = Console.ReadLine();
    if (line == null || line == "")
    {
        Console.WriteLine("Вы ничего не ввели!");
        return 0;
    }
    return int.Parse(line);
}
/* ------------------------------------------------ */

int size = PromptNumber("Введите размер массива: ");
int[] numberArray = new int[size];

FillArrayWithRandom(numberArray, 1, 20);
PrintArray(numberArray);