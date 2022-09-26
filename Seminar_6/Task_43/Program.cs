// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("y = k1 * x + b1");
System.Console.WriteLine("y = k2 * x + b2");
string[] arguments = { "b1", "k1", "b2", "k2" };

System.Console.WriteLine("Введите аргументы уравнений для расчёта точки пересечения");

double[] arg = FillArray(arguments);
//само уравнение я решил вне программы
double pointX = (arg[2] - arg[0]) / (arg[1] - arg[3]); // x = ( b2 - b1 ) / ( k1 - k2 )
double pointY = arg[1] * pointX + arg[0]; // y = k1 * x + b1     (хотя можно проверять по любому из двух уравнений данных в условии)

System.Console.WriteLine($"Коорджинаты точки пересечения = ({pointX} ; {pointY})");

double[] FillArray(string[] arguments)
{
    double[] arg = new double[arguments.Length];
    for (int i = 0; i < arguments.Length; i++)
    {
        Console.Write($"Введите {arguments[i]} = ");
        arg[i] = double.Parse(Console.ReadLine()!);
    }
    return arg;
}