// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

//[3 7 22 2 78] -> 76


double[] GetBinArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

double FindMax (double[] array)
{
    double max = array[0];;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        
    }
    return min;
}

double ShowMinMax(double[] array)
{
    double n = FindMax(array) - FindMin(array);
    return n;
}
int n = 20;

double[] mas = GetBinArray(n);
Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");

double maxNumbers = FindMax(mas);
Console.WriteLine($"Максимальное значение:{maxNumbers}");

double minNumbers = FindMin(mas);
Console.WriteLine($"Минимальное значение:{minNumbers}");

double rezult = ShowMinMax(mas);
Console.WriteLine($"Разница между максимальным и минимальным значением:{rezult}");