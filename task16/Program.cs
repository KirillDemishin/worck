// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1/num2==num2)
// {
//     Console.WriteLine("Да, верно!");
// }
// else
// {
//     Console.WriteLine("Нет, не верно!");
// }

bool result= MultTwoNum(num1,num2);
Console.WriteLine(result? "Да" : "Нет");

bool MultTwoNum(int number1, int number2)
{
    return number1/number2==number2|| number2/number1 ==number1;
}






