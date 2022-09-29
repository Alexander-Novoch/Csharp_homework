// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] numbers = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
int x = EnterInt("Введит номер строки Х =: ");
int y = EnterInt("Введит номер столбца Y =: ");

Print2DArray(numbers);

if (x > rows || y > columns)
    Console.WriteLine("Данного элемента нет в данном массиве");
else
    Console.WriteLine($" Ваш элемент = {numbers[x - 1, y - 1]}");   //-1 --> сделано для пользователя,
                                                                    // потому что редко кто бращается к первому элементу как [0,0]




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

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}