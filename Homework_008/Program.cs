﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string? number = Console.ReadLine();
void checkinNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число {number} - палиндром");
    }
    else Console.WriteLine($"Ваше число {number} - не палиндром");
}
if (number.Length == 5)
{
    checkinNumber(number);
}
else Console.WriteLine("Введите правильнео число");

