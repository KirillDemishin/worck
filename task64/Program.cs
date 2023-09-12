



Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) 
{ 
    System.Console.WriteLine("Ошибка ввода!");
    return;
}
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    System.Console.Write($"{num} ");
}