// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


static int DigitSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(input);
Console.WriteLine($"Сумма цифр числа {input} равна {sum}");