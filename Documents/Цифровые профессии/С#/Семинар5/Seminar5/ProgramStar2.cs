/*Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька.
 Реализовать невозрастающую сторировку. 
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/ 

static int[] BubbleSort(int[] mas)
{
    int temp;
	for (int i = 0; i < mas.Length; i++)
	{
	for (int j = i + 1; j < mas.Length; j++)
	{
	if (mas[i] < mas[j])
	{
	temp = mas[i];
	mas[i] = mas[j];
    mas[j] = temp;
	}                   
	}            
	}
	return mas;
}

{
    Console.WriteLine("Сколько чисел будем сортировать?");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите числа для сортировки:");
    int[] mas=new int[N];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    BubbleSort(mas);
    Console.WriteLine("После сортировки:");
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i]);
    }
    Console.ReadLine();
}