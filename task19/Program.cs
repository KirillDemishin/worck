// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrome(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = (number % 10000) / 1000;
    int fourthDigit = (number % 100) / 10;
    int fifthDigit = number % 10;

    return (firstDigit == fifthDigit && secondDigit == fourthDigit);
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool isPalindrome = IsPalindrome(number);

Console.WriteLine(isPalindrome ? "Данное число является палиндромом." : "Данное число не является палиндромом.");
