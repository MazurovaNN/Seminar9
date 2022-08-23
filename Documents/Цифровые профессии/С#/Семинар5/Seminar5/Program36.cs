/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/ 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int GetSum(int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i+=2)
    {
        sum+=mass[i];
    }
    return sum;
}

Console.Write("Введите число элементов массива: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxNumber = int.Parse(Console.ReadLine());
int[] array = GetArray(count, minNumber, maxNumber);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях массива равна {GetSum(array)}");