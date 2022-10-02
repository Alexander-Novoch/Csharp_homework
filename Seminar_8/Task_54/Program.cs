// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] numbers = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

Print2DArray(numbers);
SortEveryRow(numbers);
Print2DArray(numbers);

void SortEveryRow(int[,] numbers)
{
    Console.WriteLine();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] <= numbers[i, k + 1])
                {
                    int reverse = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = reverse;
                }
            }
        }

    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < numbers.GetUpperBound(1) + 1; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}