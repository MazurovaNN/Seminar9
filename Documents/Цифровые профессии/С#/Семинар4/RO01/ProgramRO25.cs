/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Реализовать функцию возведения в степень самостоятельно!
*/ 
Console.Write ("Введите число для возведения в степень: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for(int i=1; i <= numB; i++)
    {
        result = result * numA;

    }

// int result = Math.Pow(numA, numB);
    return result;
}
int exponentiation = Exponentiation(numA, numB);
Console.Write("Ответ: " + exponentiation); 
