﻿// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine(result);

int twoNumber = TwoNumber(number);
Console.WriteLine(twoNumber);

int TwoNumber(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}