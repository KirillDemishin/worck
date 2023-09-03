// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону триугольника");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону триугольника");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону триугольника");
int num3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(num1,num2,num3);
Console.WriteLine(result? "Триугольник существует" : "Триугольник не существует");

bool IsExistTriangle (int side1, int side2, int side3 )
{
    return side1 < side2 + side3 && side2 < side1 + side3 && side3 < side2 + side1;
}





