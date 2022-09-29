// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbers = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.GetUpperBound(1) + 1; // количество столбцов

Print2DArray(numbers);
for (int i = 0; i < columns; i++)
{
    Console.WriteLine($"В {i + 1} столбце Среднее арифметическое = {Math.Round(ArithmeticMean(numbers, rows, i),2)}");
}



void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

double ArithmeticMean(int[,] numbers, int rows, int i)
{
    double sum = 0;            
    for (int j = 0; j < rows; j++)
        sum += numbers[j, i];

    double arMean = sum / rows;
    return arMean;

}