/*Задача 34 Задайте массив заполненный случайными положительными трёхзначными
 числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/ 

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int GetSum(int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0) sum++;
    }
    return sum;
}

Console.Write("Введите число элементов массива: ");
int count = int.Parse(Console.ReadLine());
int[] array = GetArray(count);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве равно {GetSum(array)}");