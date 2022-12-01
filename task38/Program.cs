// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Difference(double min, double max)
{
    double num = max - min;
    double result = Math.Round(num, 1);
    return result;
}

double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double Min(double[] array, double max)
{
    double min = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

double[] arr = CreateArrayRndDouble(4, 1, 100);
PrintArray(arr);
double max = Max (arr);
double min = Min (arr, max);
double result = Difference(min, max);
Console.Write($" -> {result}");
