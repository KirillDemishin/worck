// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

double FindMaxMinElementsArr(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>max) max = arr[i];
        if (arr[i]<min) min = arr[i];
    }
    double diff = max - min;
    return diff;
}



void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:f1},");
        else Console.Write($"{arr[i]:f1}");
    }
    Console.WriteLine("]");
}

double[] array = CreateArrayRndDouble(4, 1, 100);
PrintArrayDouble(array);
double findMaxMinElementsArr = FindMaxMinElementsArr(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами: = {findMaxMinElementsArr:f1} ");




