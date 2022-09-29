// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = EnterInt("Введит колличество строк m =: ");
int n = EnterInt("Введит колличество столбцов n =: ");

double[,] numbers = new double[m, n];
Fill2DArray(numbers, m, n);
Print2DArray(numbers, m, n);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int m, int n)
{
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            numbers[i, j] = new Random().Next(-10, 11);
}

void Print2DArray(double[,] numbers, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}