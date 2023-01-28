/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
void ReverseNumsInArray(int[] numArray)
{
    int length = numArray.Length;
    for (int i = 0; i < length; i++)
    {
        int tempNum = numArray[i];  
        int reverseNum = tempNum * -1;
        numArray[i] = reverseNum;
    }
}


int[] GenerateArrayWithRandom(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        int randNum = new Random().Next(from, (to + 1));
        array[i] = randNum;
    }
    return array;
}


/* ----------- Генерируем массив ----------------------------- */
int[] numsArr = GenerateArrayWithRandom(12, -9, 9);
Console.WriteLine("[" + String.Join(", ", numsArr) + "]");
ReverseNumsInArray(numsArr);
Console.WriteLine("[" + String.Join(", ", numsArr) + "]");
/* ----------------------------------------------------------- */