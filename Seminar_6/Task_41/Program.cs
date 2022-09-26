// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// так как в задании не указано точно как вводить числа, то я решил схитрить и заставить 
//пользователя немного поработать))

System.Console.WriteLine("Сколько чисел вы хотите ввести??");
System.Console.Write("M = ");
int size = int.Parse(Console.ReadLine()!);

//мне кажется что эта программа без функций будет немного короче и проще))
// int[] Numbers = new int[size];
// int PositiveNumbers = 0;

// for (int i = 0; i < size; i++)
// {
//     System.Console.WriteLine($"Введите {i + 1} число и после нажмите Enter");
//     Numbers[i] = int.Parse(Console.ReadLine()!);
//     if (Numbers[i] > 0)
//         PositiveNumbers++;
// }
//Console.WriteLine($"Колличество введенных чисел > 0 = {PositiveNumbers}");

int[] Numbers = CreateAndFillArray(size);
PositiveNumbers(Numbers);


int[] CreateAndFillArray(int size)
{
    int[] Numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} число и после нажмите Enter");
        Numbers[i] = int.Parse(Console.ReadLine()!);
    }
    return Numbers;
}

void PositiveNumbers(int[] Numbers)
{
    int sum = 0;
    foreach (int number in Numbers)
    {
        if(number > 0)
            sum++;
    }
    Console.WriteLine($"Колличество введенных чисел > 0 = {sum}");
}
