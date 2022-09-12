// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
using System;

Console.WriteLine("Введите через пробел восемь чисел");
string numbers = Console.ReadLine()!;
string[] parts = numbers.Split(' ');  //можно просто распечатать уже этот массив, но мне кажется создать массив чисел более правильно
int[] array = new int[8];

Complection(parts);
paint(array);

//for(int i = 0; i < 8; i++){
//    array[i] = int.Parse(parts[i]);
//    if (i < 7)
//        Console.Write($"{array[i]}, ");
//    else
//        Console.WriteLine(array[i]);
//}
//это простое решение, и я попытался сделать функции


int[] Complection(string[] parts){
    for(int i = 0; i < 8; i++)
      array[i] = int.Parse(parts[i]);
    return array;
}

void paint(int[] array){
    for(int i = 0; i < 8; i++)
        if (i < 7)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine(array[i]);
}
//вроде получилось))