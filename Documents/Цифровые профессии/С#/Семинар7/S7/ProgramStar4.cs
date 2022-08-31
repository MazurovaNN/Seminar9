/*Задача *.  Написать программу для перевода римских чисел в десятичные арабские.

III -> 3
LVIII -> 58
MCMXCIV -> 1994
*/

int GetDigit(char digit)
{
    switch (digit)
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
    }
}

int RimToAr(String rim)
{
    int ar = 0;
    for (int i = 0; i < rim.Length; i++)
    {
        int dig = GetDigit(rim[i]);
        if (dig == 0)
        {
            return 0;
        }
        if (i + 1 < rim.Length)
        {
            int nextDig = GetDigit(rim[i + 1]);
            if (nextDig <= dig)
            {
                ar += dig;
            }
            else
            {
                ar += (nextDig - dig); // для IV и IX
                i++;
            }
        }
        else
        {
            ar += dig; // последний символ

        }
    }
    return ar;
}

Console.Write("Введите Pимское число: ");
string rimDig = Console.ReadLine();
if (RimToAr(rimDig) == 0) Console.WriteLine("Вы ввели неверное число");
else Console.WriteLine($"Римское число {rimDig} = {RimToAr(rimDig)}");
