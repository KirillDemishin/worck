// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int twoNumber = TwoNumber(num);
Console.WriteLine(twoNumber);

int TwoNumber(int num)
{
    int firstDigit = num % 100;
    int lastDigit = num / 10;
    int result = TwoNumber;
    return result;
}