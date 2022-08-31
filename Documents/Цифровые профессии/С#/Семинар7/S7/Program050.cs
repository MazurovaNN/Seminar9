/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет
*/


int[,] GetArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    int[,] res = new int[sizeX, sizeY];
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue+1);
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

void VerifyPosition(int[,] mass2, int positionRow, int positionCol)
{
    if (mass2.GetLength(0) - 1 >= positionRow && mass2.GetLength(1) - 1 >= positionCol)
    {
        Console.WriteLine($"Элемент ({positionRow}, {positionCol}) равен {mass2[positionRow, positionCol]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }

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
Console.Write("Введите первую позицию элемента для проверки: ");
int verifyRow = int.Parse(Console.ReadLine());
Console.Write("Введите вторую позицию элемента для проверки: ");
int verifyCol = int.Parse(Console.ReadLine());
VerifyPosition(array, verifyRow, verifyCol);