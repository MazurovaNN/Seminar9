/*Задача со звездочкой:
Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход 
целочисленное значение x и возвращает целую часть квадратного корня
от введенного числа.
4 -> 2
28 -> 5
Нельзя использовать встроенные функции библиотеки Math!
*/

int FindSqrt(int num)
{
    int count = 0;
    int oddNum = 1;
    while (num >= oddNum)
    {
        num -= oddNum;
        oddNum += 2;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
Console.Write($"Целая часть квадратного корня от {numb} равна {FindSqrt(numb)} ");
Console.WriteLine();