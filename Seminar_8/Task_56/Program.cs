// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] numbers = new int[4, 4] { { 1, 7, 4, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

Print2DArray(numbers);

int[] arraySumRow = Summary(numbers);

//PrintArray (arraySumRow);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {MinSumRow(arraySumRow)}");


void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}



int[] Summary(int[,] numbers)
{
    int[] summ = new int[numbers.GetLength(0)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            summ[i] += numbers[i, j];
        }
        //Console.WriteLine(summ[i]); //можно включить чтобы увидеть значение суммы каждой строки
    }
    return summ;
}

int MinSumRow(int[] arraySumRow)
{
    int min = arraySumRow[0];
    int min2 = 0;
    for (int i = 1; i < arraySumRow.GetLength(0); i++)
        if (arraySumRow[i] <= min)
        {
            min = arraySumRow[i];
            min2 = i + 1;           //+1 добавляем для удобства пользователя
        }
    if (min2==0)                   // это условие тоже для удобства пользователя
        min2++;
    return min2;
}