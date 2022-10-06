/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
чисел в массиве.

[345, 897, 568, 234] -> 2*/

void FillingArray(int[] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++ )
    {
        Random rand = new Random();
        array[i] = rand.Next(min, max);
    }
}


int NumberOfPositiveNumbers(int[] array)
{
    int PositiveNumbers = 0;
    for (int i = 0; i<array.Length; i++ )
    {   if (array[i] % 2 == 0)
        { 
            PositiveNumbers++;
        }
    }
    return PositiveNumbers;
}

void WriteArray(int[] array)

{
    for (int i = 0; i<array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Задайте размер массива: N = ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];

FillingArray(array, 100, 1000);
int PositiveNumbers = NumberOfPositiveNumbers(array);
WriteArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {PositiveNumbers}");