// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = new int[2, 2] { { 2, 4 }, { 3, 2, } };
Print2DArray(matrix1);
int[,] matrix2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };
Print2DArray(matrix2);
int[,] matrix3 = MultiplyArray(matrix1, matrix2);
Print2DArray(matrix3);


void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplyArray(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
   
    for (int i = 0; i < matrix3.GetLength(0); i++)
        for (int j = 0; j < matrix3.GetLength(1); j++)             
            for (int k = 0; k < matrix1.GetLength(1); k++)
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        
    return matrix3;
}