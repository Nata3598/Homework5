/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

void FillgArray(int [] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++ )
    {
        Random rand = new Random();
        array[i] = rand.Next(min, max);
    }
}

int SumOfArrayElements(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i <array.Length; i++ )
    {
        if (i % 2 != 0)
        {
            sumElements = sumElements + array[i];
        }
    }
    return sumElements;
}

void WriteArray(int[] array)

{
    for (int i = 0; i<array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Задайте размер одномерного массива: N = ");

int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];

FillgArray(array, 1, 10);
WriteArray(array);
int sumElements  = SumOfArrayElements(array);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {sumElements}");