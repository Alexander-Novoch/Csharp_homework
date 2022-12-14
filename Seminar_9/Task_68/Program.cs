//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{Akerman(m,n)}");


int Akerman(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return Akerman(n - 1, 1);
                if (n > 0 && m > 0) return Akerman(n - 1, Akerman(n, m - 1));
                return Akerman(n,m);
            }