// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
using static System.Console;

Clear();

//Решение 1

// WriteLine("Введите пятизначное число");
// string? num = ReadLine();

// void CheckingNumber(string num)
// {
// if (num[0]== num[4] || num[1]==num [3]) WriteLine($"Число: {num} - палиндром.");
// else WriteLine($"Число: {num} - не палиндром.");
// }

// if (num!.Length == 5)
// {CheckingNumber($"{num}");}
// else WriteLine($"Введи правильное число");

//Решение 2

WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
int revers_num = 0;
int entered_num = num;
while (num>0)
{
    result = num % 10;
    num /= 10;
    revers_num = revers_num * 10 + result;
}

//Console.WriteLine($"Перевернутое число равно {revers_num}");

string text = entered_num == revers_num ? "Число полиндром": "Число не полиндром";
WriteLine(text);