/*Задача 38. Задайте массив вещественных чисел. Найдите разницу между 
максимальным и  минимальным элементов массива.
[3 7 22 2 78] -> 76
*/ 


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return res;
}

double GetMax(double[] mass)
{
    double max = mass[0];
    for (int i = 1; i < mass.Length; i++)
    {
        if (mass[i]>max) max = mass[i];
    }
    return max;
}

double GetMin(double[] mass)
{
    double min = mass[0];
    for (int i = 1; i < mass.Length; i++)
    {
        if (mass[i]<min) min = mass[i];
    }
    return min;
}

Console.Write("Введите число элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
double[] array = GetArray(count, minNumber, maxNumber);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Минимальный элемент равен {GetMin(array)}");
Console.WriteLine($"Максимальный элемент равен {GetMax(array)}");
Console.WriteLine($"Разница равна {GetMax(array) - GetMin(array)}");
