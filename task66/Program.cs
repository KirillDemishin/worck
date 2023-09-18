// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите натуральное число M:");
int numM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число N:");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0 || numN < 0)
{
    Console.WriteLine("Введино некоректное число!");
    return;
}

int SumNaturalElements(int numM, int numN)
{
    if (numM == numN) return numM;
    else return numM + SumNaturalElements(numM + 1, numN);
}

if (numM < numN)
Console.WriteLine($"Сумма натуральных чисел в промежутке от {numM} до {numN} -> {SumNaturalElements(numM, numN)}");
if (numM > numN)
Console.WriteLine($"Сумма натуральных чисел в промежутке от {numN} до {numM} -> {SumNaturalElements(numN, numM)}");








