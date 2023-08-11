// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели (1-7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1) Console.WriteLine("Этот день не является выходным");
if (dayNumber == 2) Console.WriteLine("Этот день не является выходным");
if (dayNumber == 3) Console.WriteLine("Этот день не является выходным");
if (dayNumber == 4) Console.WriteLine("Этот день не является выходным");
if (dayNumber == 5) Console.WriteLine("Этот день не является выходным");
if (dayNumber == 6) Console.WriteLine("Этот день является выходным");
if (dayNumber == 7) Console.WriteLine("Этот день является выходным");
