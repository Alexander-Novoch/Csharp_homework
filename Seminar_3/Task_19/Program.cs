// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using System;

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;
Console.Write(number);

bool IsPolyndrome = Polyndrome(number);
string txt = IsPolyndrome == true? "-> Да, это полиндром" : "-> Нет, это не полиндром";
Console.WriteLine(txt);

bool Polyndrome(string number){
    bool check = true;
    for (int i = 0; i < number.Length / 2; i++)
        if  (number[i] != number[number.Length-i-1])
            return false;
    return check;
}