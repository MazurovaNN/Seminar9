/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    int[,] res = new int[sizeX, sizeY];
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return res;
}

void PrintArray(int[,] mass1)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            Console.Write($"{mass1[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetAverage(int[,] mass2)
{
    double[] average = new double[mass2.GetLength(1)];
    for (int j = 0; j < mass2.GetLength(1); j++)
    {
        for (int i = 0; i < mass2.GetLength(0); i++)
        {
            average[j] += mass2[i, j];
        }
        average[j] /= mass2.GetLength(0);
    }
    return average;
}

void PrintRes(double[] mass3)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < mass3.Length; i++)
    {

        Console.Write($" {mass3[i]:f1} ");
    }
    Console.WriteLine();
}

Console.Write("Введите число строк массива : ");
int countX = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива : ");
int countY = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
int[,] array = GetArray(countX, countY, minNumber, maxNumber);
PrintArray(array);
Console.WriteLine();
double[] res = GetAverage(array);
PrintRes(res);
